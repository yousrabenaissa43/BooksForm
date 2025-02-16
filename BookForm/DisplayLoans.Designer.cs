namespace BookForm
{
    partial class DisplayLoans
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
        private void InitializeComponent()
        {
            lstLoans = new ListBox();
            SuspendLayout();
            // 
            // lstLoans
            // 
            lstLoans.BackColor = Color.MistyRose;
            lstLoans.FormattingEnabled = true;
            lstLoans.Location = new Point(12, 15);
            lstLoans.Margin = new Padding(3, 4, 3, 4);
            lstLoans.Name = "lstLoans";
            lstLoans.Size = new Size(1219, 444);
            lstLoans.TabIndex = 0;
            // 
            // DisplayLoans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 481);
            Controls.Add(lstLoans);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DisplayLoans";
            Text = "Display Books";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstLoans;
    }
}