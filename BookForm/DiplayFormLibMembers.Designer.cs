namespace BookForm
{
    partial class DiplayFormLibMembers
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
            lstLibMembers = new ListBox();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstLibMembers.BackColor = Color.MistyRose;
            lstLibMembers.FormattingEnabled = true;
            lstLibMembers.Location = new Point(12, 14);
            lstLibMembers.Margin = new Padding(3, 4, 3, 4);
            lstLibMembers.Name = "lstBooks";
            lstLibMembers.Size = new Size(693, 324);
            lstLibMembers.TabIndex = 0;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 351);
            Controls.Add(lstLibMembers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DisplayForm";
            Text = "Display Books";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstLibMembers;
    }
}
