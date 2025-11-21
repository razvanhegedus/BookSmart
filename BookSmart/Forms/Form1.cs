using BookSmart.Models;
using BookSmart.Services.BookManagment;
using BookSmart.Services.OrderManagment;
using BookSmart.Services.RentalManagment;
using BookSmart.Services.Utility;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSmart
{
    public partial class Form1 : Form
    {
        // Repositories & services
        private readonly IBookRepository _bookRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IFeeService _feeService;
        private readonly IIdService _idService;

        // In-memory data
        private List<Book> _books = new();
        private List<Rental> _rentals = new();
        private List<Order> _orders = new();

        private Book? _selectedBook;

        public Form1()
        {
            InitializeComponent();

            _bookRepository = new BookRepository();
            _rentalRepository = new RentalRepository();
            _orderRepository = new OrderRepository();
            _feeService = new FeeService();
            _idService = new IdService();

            ConfigureInitialState();
            LoadDataAsync();
        }

        // -------------------------------------------------------------
        // Initial UI setup
        // -------------------------------------------------------------
        private void ConfigureInitialState()
        {
            lblAvailability.Text = string.Empty;
            lblDueDate.Text = string.Empty;
            lblFeeResult.Text = string.Empty;
            lblOrderResult.Text = string.Empty;

            btnRent.Enabled = false;
            btnOrder.Enabled = false;
            btnCalculateFee.Enabled = false;
        }

        // -------------------------------------------------------------
        // Data loading
        // -------------------------------------------------------------
        private async void LoadDataAsync()
        {
            try
            {
                _books = await _bookRepository.LoadBooksAsync();
                _rentals = await _rentalRepository.LoadRentalsAsync(_books);
                _orders = await _orderRepository.LoadOrdersAsync();

                Log("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Error loading data.");
            }
        }

        private void Log(string message)
        {
            listBoxOutput.Items.Add($"{DateTime.Now:HH:mm:ss}  {message}");
        }

        // -------------------------------------------------------------
        // SEARCH
        // -------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a book title.", "Input required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _selectedBook = _bookRepository.FindBookByTitle(_books, title);

            if (_selectedBook == null)
            {
                lblAvailability.Text = "Not found";
                btnRent.Enabled = false;
                btnOrder.Enabled = true;        // can order if not found
                btnCalculateFee.Enabled = false;

                Log($"Book '{title}' not found.");
                return;
            }

            lblAvailability.Text = _selectedBook.IsAvailable ? "Available" : "Not available";

            btnRent.Enabled = _selectedBook.IsAvailable;
            btnOrder.Enabled = !_selectedBook.IsAvailable;  // order only if not available
            btnCalculateFee.Enabled = true;

            Log($"Found book: {_selectedBook.Title} (Available: {_selectedBook.IsAvailable})");
        }

        // -------------------------------------------------------------
        // RENT BOOK
        // -------------------------------------------------------------
        private async void btnRent_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Search and select a book first.");
                return;
            }

            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter a customer name.", "Input required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_selectedBook.IsAvailable)
            {
                MessageBox.Show("This book is not available for rent.", "Not available",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime start = DateTime.Now;
            DateTime due = start.AddDays(Config.DefaultRentalDays);

            var rental = new Rental(
                _idService.GenerateId("R-"),
                new Customer(customerName),
                _selectedBook,
                start,
                due
            );

            _rentals.Add(rental);
            _selectedBook.IsAvailable = false;

            try
            {
                await _rentalRepository.SaveRentalsAsync(_rentals);
                await _bookRepository.SaveBooksAsync(_books);

                lblDueDate.Text = due.ToShortDateString();
                Log($"Rented '{_selectedBook.Title}' to {customerName}. Due: {due:d}");
                MessageBox.Show("Book rented successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving rental: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Error saving rental.");
            }
        }

        // -------------------------------------------------------------
        // LATE FEE CALCULATION
        // -------------------------------------------------------------
        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Search and select a book first.");
                return;
            }

            // Find the active rental for this book (not yet returned)
            var rental = _rentals
                .Where(r => r.Book.Id == _selectedBook.Id && !r.ReturnDate.HasValue)
                .OrderByDescending(r => r.StartDate)
                .FirstOrDefault();

            if (rental == null)
            {
                MessageBox.Show("No active rental found for this book.");
                return;
            }

            decimal fee = _feeService.CalculateLateFee(rental, DateTime.Now);

            if (fee <= 0)
            {
                lblFeeResult.Text = "No late fee.";
                Log($"No late fee for '{rental.Book.Title}'.");
            }
            else
            {
                lblFeeResult.Text = $"{fee:0.00} RON";
                Log($"Late fee for '{rental.Book.Title}' = {fee:0.00} RON");
            }
        }

        // -------------------------------------------------------------
        // ORDER BOOK
        // -------------------------------------------------------------
        private async void btnOrder_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();
            string customerName = txtCustomerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Enter a book title to order.");
                return;
            }

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Enter a customer name.");
                return;
            }

            if (!int.TryParse(txtDeliveryDays.Text.Trim(), out int days) || days <= 0)
            {
                MessageBox.Show("Enter a valid positive number of delivery days.");
                return;
            }

            DateTime orderDate = DateTime.Now;
            DateTime eta = orderDate.AddDays(days);

            var order = new Order(
                _idService.GenerateId("O-"),
                new Customer(customerName),
                title,
                string.Empty,            // author not required for order
                orderDate,
                eta
            );

            _orders.Add(order);

            try
            {
                await _orderRepository.SaveOrdersAsync(_orders);

                lblOrderResult.Text = $"Expected: {eta:d}";
                Log($"Order created for '{title}' (ETA: {eta:d})");
                MessageBox.Show("Order saved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Error saving order.");
            }
        }
    }
}
