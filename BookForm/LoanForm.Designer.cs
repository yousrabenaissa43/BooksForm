namespace BookForm
{
    partial class LoanForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify  
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            cmbMembers = new ComboBox();
            label3 = new Label();
            cmbBooks = new ComboBox();
            label4 = new Label();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(606, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 8;
            button1.Text = "Submit Loan";
            button1.Click += btnSubmit_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(401, 340);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(262, 340);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Due Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(401, 269);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(296, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(262, 269);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Loan Date:";
            // 
            // cmbMembers
            // 
            cmbMembers.Location = new Point(401, 200);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(296, 28);
            cmbMembers.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(262, 205);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 2;
            label3.Text = "Select Member:";
            // 
            // cmbBooks
            // 
            cmbBooks.Location = new Point(401, 135);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(296, 28);
            cmbBooks.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(262, 135);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Select Book:";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(435, 396);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(83, 29);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // LoanForm
            // 
            BackgroundImage = Properties.Resources.ee1d5fe2_4adc_45ca_bd69_e735d5aff231;
            ClientSize = new Size(998, 524);
            Controls.Add(btnDisplay);
            Controls.Add(label4);
            Controls.Add(cmbBooks);
            Controls.Add(label3);
            Controls.Add(cmbMembers);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "LoanForm";
            Text = "New Loan";
            ResumeLayout(false);
        }
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private ComboBox cmbMembers;
        private Label label3;
        private ComboBox cmbBooks;
        private Label label4;
        private Button btnDisplay;
    }
}