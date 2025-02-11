namespace BookForm
{
    partial class DisplayAuthorsForm
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
            lstAuthors = new ListBox();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstAuthors.BackColor = Color.MistyRose;
            lstAuthors.FormattingEnabled = true;
            lstAuthors.Location = new Point(12, 15);
            lstAuthors.Margin = new Padding(3, 4, 3, 4);
            lstAuthors.Name = "lstBooks";
            lstAuthors.Size = new Size(360, 324);
            lstAuthors.TabIndex = 0;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 351);
            Controls.Add(lstAuthors);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DisplayForm";
            Text = "Display Books";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstAuthors;
    }
}