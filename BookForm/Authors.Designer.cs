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
            btnAdd = new Button();
            btnDisplay = new Button();
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.Location = new Point(211, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.MistyRose;
            btnDisplay.Location = new Point(337, 285);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(80, 30);
            btnDisplay.TabIndex = 26;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click_1;
            // 
            // Authors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.authors;
            ClientSize = new Size(673, 359);
            Controls.Add(groupBox2);
            Controls.Add(btnAdd);
            Controls.Add(btnDisplay);
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
        private Button btnAdd;
        private Button btnDisplay;
    }
}