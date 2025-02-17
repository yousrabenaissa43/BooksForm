namespace BookForm
{
    partial class Authors
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            tbBiography = new TextBox();
            tbName = new TextBox();
            button4 = new Button();
            button3 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbBiography);
            groupBox2.Controls.Add(tbName);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(197, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 182);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 78);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 16;
            label1.Text = "Biography :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 29);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 14;
            label4.Text = "Name :";
            // 
            // tbBiography
            // 
            tbBiography.Location = new Point(100, 78);
            tbBiography.Name = "tbBiography";
            tbBiography.Size = new Size(120, 27);
            tbBiography.TabIndex = 17;
            // 
            // tbName
            // 
            tbName.Location = new Point(100, 29);
            tbName.Name = "tbName";
            tbName.Size = new Size(120, 27);
            tbName.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Location = new Point(211, 285);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 25;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Location = new Point(337, 285);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 26;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Authors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.authors;
            ClientSize = new Size(673, 359);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Authors";
            Text = "Authors";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private TextBox tbBiography;
        private TextBox tbName;
        private Button button4;
        private Button button3;
    }
}