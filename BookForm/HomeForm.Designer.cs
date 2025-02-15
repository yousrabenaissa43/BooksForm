namespace BookForm
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageAuthors;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnManageMembers = new Button();
            btnManageBooks = new Button();
            btnManageAuthors = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.MistyRose;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(237, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to the Library";
            // 
            // btnManageMembers
            // 
            btnManageMembers.Location = new Point(288, 128);
            btnManageMembers.Name = "btnManageMembers";
            btnManageMembers.Size = new Size(200, 40);
            btnManageMembers.TabIndex = 1;
            btnManageMembers.Text = "Manage Library Members";
            btnManageMembers.Click += btnManageMembers_Click;
            // 
            // btnManageBooks
            // 
            btnManageBooks.Location = new Point(288, 205);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(200, 40);
            btnManageBooks.TabIndex = 2;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnManageAuthors
            // 
            btnManageAuthors.Location = new Point(288, 302);
            btnManageAuthors.Name = "btnManageAuthors";
            btnManageAuthors.Size = new Size(200, 40);
            btnManageAuthors.TabIndex = 3;
            btnManageAuthors.Text = "Manage Authors";
            btnManageAuthors.Click += btnManageAuthors_Click;
            // 
            // HomeForm
            // 
            BackgroundImage = Properties.Resources.lib;
            ClientSize = new Size(790, 478);
            Controls.Add(lblTitle);
            Controls.Add(btnManageMembers);
            Controls.Add(btnManageBooks);
            Controls.Add(btnManageAuthors);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library System";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}