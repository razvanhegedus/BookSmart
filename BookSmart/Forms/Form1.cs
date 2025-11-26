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
        private readonly IBookRepository _bookRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IFeeService _feeService;
        private readonly IIdService _idService;

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

        private void ConfigureInitialState()
        {
            lblAvailability.Text = "";
            lblDueDate.Text = "";
            lblFeeResult.Text = "";
            lblOrderResult.Text = "";

            btnRent.Enabled = false;
            btnReturn.Enabled = false;
            btnRenew.Enabled = false;
            btnOrder.Enabled = false;
            btnCalculateFee.Enabled = false;
            txtRenewDays.Enabled = false;
        }

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
                MessageBox.Show($"Failed to load data: {ex.Message}");
                Log("Error loading data.");
            }
        }

        private void Log(string msg)
        {
            listBoxOutput.Items.Insert(0, $"{DateTime.Now:HH:mm:ss}  {msg}");
        }

        private Rental? GetActiveRental(string bookId)
        {
            return _rentals
                .Where(r => r.Book.Id == bookId && !r.ReturnDate.HasValue)
                .OrderByDescending(r => r.StartDate)
                .FirstOrDefault();
        }

        // -------------------------------------------------------------
        // SEARCH BOOK
        // -------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a book title.");
                return;
            }

            _selectedBook = _bookRepository.FindBookByTitle(_books, title);

            if (_selectedBook == null)
            {
                lblAvailability.Text = "Not found";
                lblAvailability.ForeColor = Color.Gray;

                btnRent.Enabled = false;
                btnReturn.Enabled = false;
                btnRenew.Enabled = false;
                txtRenewDays.Enabled = false;
                btnOrder.Enabled = true;

                lblDueDate.Text = "";
                Log($"Book '{title}' not found.");
                return;
            }

            lblAvailability.Text = _selectedBook.IsAvailable ? "Available" : "Not available";
            lblAvailability.ForeColor = _selectedBook.IsAvailable ? Color.Green : Color.Red;

            var activeRental = GetActiveRental(_selectedBook.Id);
            bool isRented = activeRental != null;

            btnRent.Enabled = _selectedBook.IsAvailable;
            btnReturn.Enabled = isRented;
            btnRenew.Enabled = isRented;
            txtRenewDays.Enabled = isRented;

            btnOrder.Enabled = !_selectedBook.IsAvailable;
            btnCalculateFee.Enabled = isRented;

            lblDueDate.Text = isRented ? activeRental!.DueDate.ToShortDateString() : "";

            Log($"Found '{_selectedBook.Title}' (Available: {_selectedBook.IsAvailable})");
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

            string customer = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customer))
            {
                MessageBox.Show("Enter a customer name.");
                return;
            }

            if (!_selectedBook.IsAvailable)
            {
                MessageBox.Show("Book is not available.");
                return;
            }

            DateTime start = DateTime.Now;
            DateTime due = start.AddDays(Config.DefaultRentalDays);

            var rental = new Rental(
                _idService.GenerateId("R-"),
                new Customer(customer),
                _selectedBook,
                start,
                due
            );

            _rentals.Add(rental);
            _selectedBook.IsAvailable = false;

            await _rentalRepository.SaveRentalsAsync(_rentals);
            await _bookRepository.SaveBooksAsync(_books);

            lblDueDate.Text = due.ToShortDateString();
            lblAvailability.Text = "Not available";
            lblAvailability.ForeColor = Color.Red;

            Log($"Rented '{_selectedBook.Title}' to {customer}. Due {due:d}");
            MessageBox.Show("Book rented successfully!");

            btnRent.Enabled = false;
            btnReturn.Enabled = true;
            btnRenew.Enabled = true;
            txtRenewDays.Enabled = true;
            btnOrder.Enabled = false;
        }

        // -------------------------------------------------------------
        // RETURN BOOK
        // -------------------------------------------------------------
        private async void btnReturn_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Search a book first.");
                return;
            }

            var rental = GetActiveRental(_selectedBook.Id);
            if (rental == null)
            {
                MessageBox.Show("This book is not currently rented.");
                return;
            }

            rental.ReturnDate = DateTime.Now;
            _selectedBook.IsAvailable = true;

            await _rentalRepository.SaveRentalsAsync(_rentals);
            await _bookRepository.SaveBooksAsync(_books);

            lblAvailability.Text = "Available";
            lblAvailability.ForeColor = Color.Green;
            lblDueDate.Text = "";
            lblFeeResult.Text = "";

            btnRent.Enabled = true;
            btnReturn.Enabled = false;
            btnRenew.Enabled = false;
            txtRenewDays.Enabled = false;

            Log($"Returned '{_selectedBook.Title}'.");
            MessageBox.Show("Book returned successfully!");
        }

        // -------------------------------------------------------------
        // RENEW RENTAL
        // -------------------------------------------------------------
        private async void btnRenew_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Search a book first.");
                return;
            }

            var rental = GetActiveRental(_selectedBook.Id);
            if (rental == null)
            {
                MessageBox.Show("This book is not currently rented.");
                return;
            }

            if (!int.TryParse(txtRenewDays.Text.Trim(), out int extraDays) || extraDays <= 0)
            {
                MessageBox.Show("Enter valid number of days.");
                return;
            }

            rental.DueDate = rental.DueDate.AddDays(extraDays);

            await _rentalRepository.SaveRentalsAsync(_rentals);

            lblDueDate.Text = rental.DueDate.ToShortDateString();

            Log($"Renewed '{_selectedBook.Title}' for +{extraDays} days. New Due Date: {rental.DueDate:d}");
            MessageBox.Show("Renew successful!");
        }

        // -------------------------------------------------------------
        // CALCULATE LATE FEE
        // -------------------------------------------------------------
        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null)
            {
                MessageBox.Show("Search a book first.");
                return;
            }

            var rental = GetActiveRental(_selectedBook.Id);

            if (rental == null)
            {
                MessageBox.Show("No active rental.");
                return;
            }

            decimal fee = _feeService.CalculateLateFee(rental, DateTime.Now);
            lblFeeResult.Text = fee <= 0 ? "No late fee." : $"{fee:0.00} RON";

            Log(fee <= 0
                ? $"No late fee for '{rental.Book.Title}'."
                : $"Late fee: {fee:0.00} RON");
        }

        // -------------------------------------------------------------
        // ORDER BOOK
        // -------------------------------------------------------------
        private async void btnOrder_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();
            string customer = txtCustomerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Enter book title.");
                return;
            }

            if (string.IsNullOrWhiteSpace(customer))
            {
                MessageBox.Show("Enter customer name.");
                return;
            }

            if (!int.TryParse(txtDeliveryDays.Text.Trim(), out int days) || days <= 0)
            {
                MessageBox.Show("Enter valid delivery days.");
                return;
            }

            DateTime orderDate = DateTime.Now;
            DateTime eta = orderDate.AddDays(days);

            var order = new Order(
                _idService.GenerateId("O-"),
                new Customer(customer),
                title,
                "",
                orderDate,
                eta
            );

            _orders.Add(order);

            await _orderRepository.SaveOrdersAsync(_orders);

            lblOrderResult.Text = $"Expected arrival: {eta:d}";

            Log($"Order created for '{title}' (ETA {eta:d})");
            MessageBox.Show("Order created!");
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
