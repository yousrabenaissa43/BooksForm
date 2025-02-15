namespace BookForm
{
    partial class LibraryMembers
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            lbEmail = new Label();
            lbFullName = new Label();
            tbEmail = new TextBox();
            tbFullName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(264, 252);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 26;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Location = new Point(136, 252);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 25;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbFullName);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbFullName);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(101, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 211);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Library Member";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(10, 78);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(53, 20);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email :";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.BackColor = Color.Transparent;
            lbFullName.Location = new Point(10, 29);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(79, 20);
            lbFullName.TabIndex = 14;
            lbFullName.Text = "FullName :";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(100, 78);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(120, 27);
            tbEmail.TabIndex = 17;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(100, 29);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(120, 27);
            tbFullName.TabIndex = 15;
            // 
            // LibraryMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.libMembers;
            ClientSize = new Size(454, 316);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LibraryMembers";
            Text = "LibraryMembers";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label lbEmail;
        private Label lbFullName;
        private TextBox tbEmail;
        private TextBox tbFullName;
    }
}