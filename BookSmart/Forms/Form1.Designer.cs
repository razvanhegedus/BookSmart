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
            btnReturn = new Button();
            label1 = new Label();
            txtRenewDays = new TextBox();
            label2 = new Label();
            btnRenew = new Button();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(12, 51);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(62, 15);
            labelSearch.TabIndex = 23;
            labelSearch.Text = "Book Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(80, 48);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(164, 23);
            txtSearchTitle.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(258, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
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
            labelHeader1.TabIndex = 20;
            labelHeader1.Text = "📘 BOOK SEARCH";
            // 
            // labelRentHeader
            // 
            labelRentHeader.AutoSize = true;
            labelRentHeader.Location = new Point(12, 134);
            labelRentHeader.Name = "labelRentHeader";
            labelRentHeader.Size = new Size(152, 15);
            labelRentHeader.TabIndex = 19;
            labelRentHeader.Text = "👤 RENT / RETURN / RENEW";
       
            // labelAvailabilityText
            // 
            labelAvailabilityText.AutoSize = true;
            labelAvailabilityText.Location = new Point(12, 89);
            labelAvailabilityText.Name = "labelAvailabilityText";
            labelAvailabilityText.Size = new Size(68, 15);
            labelAvailabilityText.TabIndex = 18;
            labelAvailabilityText.Text = "Availability:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(83, 89);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(0, 15);
            lblAvailability.TabIndex = 17;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(12, 174);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(97, 15);
            labelCustomer.TabIndex = 16;
            labelCustomer.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(115, 171);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(164, 23);
            txtCustomerName.TabIndex = 15;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(18, 237);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(75, 23);
            btnRent.TabIndex = 14;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // labelFeeHeader
            // 
            labelFeeHeader.AutoSize = true;
            labelFeeHeader.Location = new Point(12, 288);
            labelFeeHeader.Name = "labelFeeHeader";
            labelFeeHeader.Size = new Size(116, 15);
            labelFeeHeader.TabIndex = 13;
            labelFeeHeader.Text = "💰 LATE FEE SECTION";
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.Location = new Point(7, 321);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(188, 23);
            btnCalculateFee.TabIndex = 12;
            btnCalculateFee.Text = "Calculate Late Fee";
            btnCalculateFee.UseVisualStyleBackColor = true;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // labelFeeText
            // 
            labelFeeText.AutoSize = true;
            labelFeeText.Location = new Point(8, 354);
            labelFeeText.Name = "labelFeeText";
            labelFeeText.Size = new Size(53, 15);
            labelFeeText.TabIndex = 11;
            labelFeeText.Text = "Late Fee:";
            // 
            // lblFeeResult
            // 
            lblFeeResult.AutoSize = true;
            lblFeeResult.Location = new Point(93, 303);
            lblFeeResult.Name = "lblFeeResult";
            lblFeeResult.Size = new Size(0, 15);
            lblFeeResult.TabIndex = 10;
            // 
            // labelDueDateText
            // 
            labelDueDateText.AutoSize = true;
            labelDueDateText.Location = new Point(18, 206);
            labelDueDateText.Name = "labelDueDateText";
            labelDueDateText.Size = new Size(58, 15);
            labelDueDateText.TabIndex = 9;
            labelDueDateText.Text = "Due Date:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(93, 206);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(0, 15);
            lblDueDate.TabIndex = 8;
            // 
            // labelOrderHeader
            // 
            labelOrderHeader.AutoSize = true;
            labelOrderHeader.Location = new Point(7, 380);
            labelOrderHeader.Name = "labelOrderHeader";
            labelOrderHeader.Size = new Size(155, 15);
            labelOrderHeader.TabIndex = 7;
            labelOrderHeader.Text = "📦 ORDER A BOOK SECTION";
            // 
            // txtDeliveryDays
            // 
            txtDeliveryDays.Location = new Point(93, 412);
            txtDeliveryDays.Name = "txtDeliveryDays";
            txtDeliveryDays.Size = new Size(56, 23);
            txtDeliveryDays.TabIndex = 6;
            // 
            // labelDays
            // 
            labelDays.AutoSize = true;
            labelDays.Location = new Point(7, 415);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(80, 15);
            labelDays.TabIndex = 5;
            labelDays.Text = "Delivery Days:";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(169, 412);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order Book";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // labelOrderResultText
            // 
            labelOrderResultText.AutoSize = true;
            labelOrderResultText.Location = new Point(8, 457);
            labelOrderResultText.Name = "labelOrderResultText";
            labelOrderResultText.Size = new Size(72, 15);
            labelOrderResultText.TabIndex = 3;
            labelOrderResultText.Text = "Order Result";
            // 
            // lblOrderResult
            // 
            lblOrderResult.AutoSize = true;
            lblOrderResult.Location = new Point(93, 415);
            lblOrderResult.Name = "lblOrderResult";
            lblOrderResult.Size = new Size(0, 15);
            lblOrderResult.TabIndex = 2;
            // 
            // labelOutputHeader
            // 
            labelOutputHeader.AutoSize = true;
            labelOutputHeader.Location = new Point(489, 20);
            labelOutputHeader.Name = "labelOutputHeader";
            labelOutputHeader.Size = new Size(92, 15);
            labelOutputHeader.TabIndex = 1;
            labelOutputHeader.Text = "📜 OUTPUT LOG";
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(489, 51);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(200, 199);
            listBoxOutput.TabIndex = 0;
            listBoxOutput.SelectedIndexChanged += listBoxOutput_SelectedIndexChanged;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(115, 237);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 241);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 25;
            label1.Text = "Renew:";
            // 
            // txtRenewDays
            // 
            txtRenewDays.Location = new Point(263, 237);
            txtRenewDays.Name = "txtRenewDays";
            txtRenewDays.Size = new Size(39, 23);
            txtRenewDays.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 240);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 27;
            label2.Text = "days";
            // 
            // btnRenew
            // 
            btnRenew.Location = new Point(345, 237);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(75, 23);
            btnRenew.TabIndex = 28;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(775, 550);
            Controls.Add(btnRenew);
            Controls.Add(label2);
            Controls.Add(txtRenewDays);
            Controls.Add(label1);
            Controls.Add(btnReturn);
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
        private Button btnReturn;
        private Label label1;
        private TextBox txtRenewDays;
        private Label label2;
        private Button btnRenew;
    }
}
