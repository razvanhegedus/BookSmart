namespace BookSmart
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelSearch = new Label();
            txtSearchTitle = new TextBox();
            btnSearch = new Button();
            labelHeader1 = new Label();
            labelRentHeader = new Label();
            labelAvailabilityText = new Label();
            lblAvailability = new Label();
            labelCustomer = new Label();
            txtCustomerName = new TextBox();
            btnRent = new Button();
            labelFeeHeader = new Label();
            btnCalculateFee = new Button();
            labelFeeText = new Label();
            lblFeeResult = new Label();
            labelDueDateText = new Label();
            lblDueDate = new Label();
            labelOrderHeader = new Label();
            txtDeliveryDays = new TextBox();
            labelDays = new Label();
            btnOrder = new Button();
            labelOrderResultText = new Label();
            lblOrderResult = new Label();
            labelOutputHeader = new Label();
            listBoxOutput = new ListBox();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(12, 51);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(62, 15);
            labelSearch.Text = "Book Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(80, 48);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(164, 23);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(258, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // labelHeader1
            // 
            labelHeader1.AutoSize = true;
            labelHeader1.Location = new Point(12, 20);
            labelHeader1.Name = "labelHeader1";
            labelHeader1.Size = new Size(99, 15);
            labelHeader1.Text = "📘 BOOK SEARCH";
            // 
            // labelRentHeader
            // 
            labelRentHeader.AutoSize = true;
            labelRentHeader.Location = new Point(12, 134);
            labelRentHeader.Name = "labelRentHeader";
            labelRentHeader.Size = new Size(94, 15);
            labelRentHeader.Text = "👤 RENT A BOOK";
            // 
            // labelAvailabilityText
            // 
            labelAvailabilityText.AutoSize = true;
            labelAvailabilityText.Location = new Point(12, 89);
            labelAvailabilityText.Name = "labelAvailabilityText";
            labelAvailabilityText.Size = new Size(65, 15);
            labelAvailabilityText.Text = "Availability:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(83, 89);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(0, 15);
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(12, 174);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(97, 15);
            labelCustomer.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(115, 171);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(164, 23);
            // 
            // btnRent
            // 
            btnRent.Location = new Point(295, 171);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(75, 23);
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // labelFeeHeader
            // 
            labelFeeHeader.AutoSize = true;
            labelFeeHeader.Location = new Point(12, 237);
            labelFeeHeader.Name = "labelFeeHeader";
            labelFeeHeader.Size = new Size(116, 15);
            labelFeeHeader.Text = "💰 LATE FEE SECTION";
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.Location = new Point(12, 264);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(188, 23);
            btnCalculateFee.Text = "Calculate Late Fee";
            btnCalculateFee.UseVisualStyleBackColor = true;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // labelFeeText
            // 
            labelFeeText.AutoSize = true;
            labelFeeText.Location = new Point(12, 303);
            labelFeeText.Name = "labelFeeText";
            labelFeeText.Size = new Size(53, 15);
            labelFeeText.Text = "Late Fee:";
            // 
            // lblFeeResult
            // 
            lblFeeResult.AutoSize = true;
            lblFeeResult.Location = new Point(93, 303);
            lblFeeResult.Name = "lblFeeResult";
            lblFeeResult.Size = new Size(0, 15);
            // 
            // labelDueDateText
            // 
            labelDueDateText.AutoSize = true;
            labelDueDateText.Location = new Point(18, 206);
            labelDueDateText.Name = "labelDueDateText";
            labelDueDateText.Size = new Size(58, 15);
            labelDueDateText.Text = "Due Date:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(93, 206);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(0, 15);
            // 
            // labelOrderHeader
            // 
            labelOrderHeader.AutoSize = true;
            labelOrderHeader.Location = new Point(18, 349);
            labelOrderHeader.Name = "labelOrderHeader";
            labelOrderHeader.Size = new Size(155, 15);
            labelOrderHeader.Text = "📦 ORDER A BOOK SECTION";
            // 
            // txtDeliveryDays
            // 
            txtDeliveryDays.Location = new Point(95, 379);
            txtDeliveryDays.Name = "txtDeliveryDays";
            txtDeliveryDays.Size = new Size(164, 23);
            // 
            // labelDays
            // 
            labelDays.AutoSize = true;
            labelDays.Location = new Point(9, 382);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(80, 15);
            labelDays.Text = "Delivery Days:";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(276, 379);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.Text = "Order Book";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // labelOrderResultText
            // 
            labelOrderResultText.AutoSize = true;
            labelOrderResultText.Location = new Point(9, 415);
            labelOrderResultText.Name = "labelOrderResultText";
            labelOrderResultText.Size = new Size(72, 15);
            labelOrderResultText.Text = "Order Result";
            // 
            // lblOrderResult
            // 
            lblOrderResult.AutoSize = true;
            lblOrderResult.Location = new Point(93, 415);
            lblOrderResult.Name = "lblOrderResult";
            lblOrderResult.Size = new Size(0, 15);
            // 
            // labelOutputHeader
            // 
            labelOutputHeader.AutoSize = true;
            labelOutputHeader.Location = new Point(439, 116);
            labelOutputHeader.Name = "labelOutputHeader";
            labelOutputHeader.Size = new Size(92, 15);
            labelOutputHeader.Text = "📜 OUTPUT LOG";
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(571, 78);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(200, 200);
            // 
            // Form1
            // 
            ClientSize = new Size(900, 550);
            Controls.Add(listBoxOutput);
            Controls.Add(labelOutputHeader);
            Controls.Add(lblOrderResult);
            Controls.Add(labelOrderResultText);
            Controls.Add(btnOrder);
            Controls.Add(labelDays);
            Controls.Add(txtDeliveryDays);
            Controls.Add(labelOrderHeader);
            Controls.Add(lblDueDate);
            Controls.Add(labelDueDateText);
            Controls.Add(lblFeeResult);
            Controls.Add(labelFeeText);
            Controls.Add(btnCalculateFee);
            Controls.Add(labelFeeHeader);
            Controls.Add(btnRent);
            Controls.Add(txtCustomerName);
            Controls.Add(labelCustomer);
            Controls.Add(lblAvailability);
            Controls.Add(labelAvailabilityText);
            Controls.Add(labelRentHeader);
            Controls.Add(labelHeader1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTitle);
            Controls.Add(labelSearch);
            Name = "Form1";
            Text = "BookSmart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private TextBox txtSearchTitle;
        private Button btnSearch;
        private Label labelHeader1;
        private Label labelRentHeader;
        private Label labelAvailabilityText;
        private Label lblAvailability;
        private Label labelCustomer;
        private TextBox txtCustomerName;
        private Button btnRent;
        private Label labelFeeHeader;
        private Button btnCalculateFee;
        private Label labelFeeText;
        private Label lblFeeResult;
        private Label labelDueDateText;
        private Label lblDueDate;
        private Label labelOrderHeader;
        private TextBox txtDeliveryDays;
        private Label labelDays;
        private Button btnOrder;
        private Label labelOrderResultText;
        private Label lblOrderResult;
        private Label labelOutputHeader;
        private ListBox listBoxOutput;
    }
}
