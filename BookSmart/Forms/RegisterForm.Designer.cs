namespace BookSmart.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelSearch = new Label();
            label2 = new Label();
            txtSearchTitle = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRent = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(148, 143);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 26;
            label1.Text = "Enter Password:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 16F);
            labelSearch.Location = new Point(148, 79);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(172, 30);
            labelSearch.TabIndex = 27;
            labelSearch.Text = "Enter Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(148, 207);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 28;
            label2.Text = "Confirm Password:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTitle.Location = new Point(357, 79);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(206, 35);
            txtSearchTitle.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(357, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 35);
            textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(357, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 35);
            textBox2.TabIndex = 31;
            // 
            // btnRent
            // 
            btnRent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRent.Location = new Point(289, 280);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(199, 43);
            btnRent.TabIndex = 32;
            btnRent.Text = "Register Now";
            btnRent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(221, 352);
            button1.Name = "button1";
            button1.Size = new Size(328, 43);
            button1.TabIndex = 33;
            button1.Text = "Have an account ? Login Now ";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRent);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtSearchTitle);
            Controls.Add(label2);
            Controls.Add(labelSearch);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSearch;
        private Label label2;
        private TextBox txtSearchTitle;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRent;
        private Button button1;
    }
}