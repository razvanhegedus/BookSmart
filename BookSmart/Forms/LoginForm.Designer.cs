namespace BookSmart.Forms
{
    partial class LoginForm
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
            labelSearch = new Label();
            label1 = new Label();
            txtSearchTitle = new TextBox();
            textBox1 = new TextBox();
            btnRent = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 16F);
            labelSearch.Location = new Point(115, 63);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(172, 30);
            labelSearch.TabIndex = 24;
            labelSearch.Text = "Enter Username:";
            labelSearch.Click += labelSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(115, 125);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 25;
            label1.Text = "Enter Password:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTitle.Location = new Point(293, 63);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(206, 35);
            txtSearchTitle.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(293, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 35);
            textBox1.TabIndex = 27;
            // 
            // btnRent
            // 
            btnRent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRent.Location = new Point(258, 180);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(114, 43);
            btnRent.TabIndex = 28;
            btnRent.Text = "Login";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(153, 246);
            button1.Name = "button1";
            button1.Size = new Size(328, 43);
            button1.TabIndex = 29;
            button1.Text = "Don't have an account ? Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 362);
            Controls.Add(button1);
            Controls.Add(btnRent);
            Controls.Add(textBox1);
            Controls.Add(txtSearchTitle);
            Controls.Add(label1);
            Controls.Add(labelSearch);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private Label label1;
        private TextBox txtSearchTitle;
        private TextBox textBox1;
        private Button btnRent;
        private Button button1;
    }
}