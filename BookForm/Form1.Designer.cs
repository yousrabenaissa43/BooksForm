namespace BookForm
{
    partial class Form1
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
            lbType = new Label();
            lbSerial = new Label();
            lbTitle = new Label();
            lbMagicType = new Label();
            lbNumRecipes = new Label();
            cbType = new ComboBox();
            cbMagicType = new ComboBox();
            tbSerial = new TextBox();
            tbTitle = new TextBox();
            tbNumRecipes = new TextBox();
            btnAdd = new Button();
            btnDisplay = new Button();
            gbSpellBook = new GroupBox();
            gbRecipeBook = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            tbBiography = new TextBox();
            tbName = new TextBox();
            button1 = new Button();
            gbSpellBook.SuspendLayout();
            gbRecipeBook.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(30, 30);
            lbType.Name = "lbType";
            lbType.Size = new Size(47, 20);
            lbType.TabIndex = 0;
            lbType.Text = "Type :";
            // 
            // lbSerial
            // 
            lbSerial.AutoSize = true;
            lbSerial.Location = new Point(30, 70);
            lbSerial.Name = "lbSerial";
            lbSerial.Size = new Size(53, 20);
            lbSerial.TabIndex = 2;
            lbSerial.Text = "Serial :";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(30, 110);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(45, 20);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Title :";
            // 
            // lbMagicType
            // 
            lbMagicType.AutoSize = true;
            lbMagicType.Location = new Point(10, 30);
            lbMagicType.Name = "lbMagicType";
            lbMagicType.Size = new Size(90, 20);
            lbMagicType.TabIndex = 0;
            lbMagicType.Text = "Magic type :";
            // 
            // lbNumRecipes
            // 
            lbNumRecipes.AutoSize = true;
            lbNumRecipes.Location = new Point(10, 30);
            lbNumRecipes.Name = "lbNumRecipes";
            lbNumRecipes.Size = new Size(145, 20);
            lbNumRecipes.TabIndex = 0;
            lbNumRecipes.Text = "Number Of Recipes :";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Spell Book", "Recipe Book" });
            cbType.Location = new Point(100, 27);
            cbType.Name = "cbType";
            cbType.Size = new Size(150, 28);
            cbType.TabIndex = 1;
            // 
            // cbMagicType
            // 
            cbMagicType.Items.AddRange(new object[] { "Enchantment", "Transmutation", "Cruse" });
            cbMagicType.Location = new Point(100, 27);
            cbMagicType.Name = "cbMagicType";
            cbMagicType.Size = new Size(120, 28);
            cbMagicType.TabIndex = 1;
            // 
            // tbSerial
            // 
            tbSerial.Location = new Point(100, 67);
            tbSerial.Name = "tbSerial";
            tbSerial.Size = new Size(150, 27);
            tbSerial.TabIndex = 3;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(100, 107);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(150, 27);
            tbTitle.TabIndex = 5;
            // 
            // tbNumRecipes
            // 
            tbNumRecipes.Location = new Point(161, 27);
            tbNumRecipes.Name = "tbNumRecipes";
            tbNumRecipes.Size = new Size(70, 27);
            tbNumRecipes.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.Location = new Point(300, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.MistyRose;
            btnDisplay.Location = new Point(400, 220);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(80, 30);
            btnDisplay.TabIndex = 11;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // gbSpellBook
            // 
            gbSpellBook.Controls.Add(lbMagicType);
            gbSpellBook.Controls.Add(cbMagicType);
            gbSpellBook.Location = new Point(300, 20);
            gbSpellBook.Name = "gbSpellBook";
            gbSpellBook.Size = new Size(250, 80);
            gbSpellBook.TabIndex = 8;
            gbSpellBook.TabStop = false;
            gbSpellBook.Text = "Spell Book";
            // 
            // gbRecipeBook
            // 
            gbRecipeBook.Controls.Add(lbNumRecipes);
            gbRecipeBook.Controls.Add(tbNumRecipes);
            gbRecipeBook.Location = new Point(300, 124);
            gbRecipeBook.Name = "gbRecipeBook";
            gbRecipeBook.Size = new Size(250, 80);
            gbRecipeBook.TabIndex = 9;
            gbRecipeBook.TabStop = false;
            gbRecipeBook.Text = "Recipe Book";
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Location = new Point(145, 482);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 23;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Location = new Point(45, 482);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 22;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbBiography);
            groupBox2.Controls.Add(tbName);
            groupBox2.Location = new Point(36, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 182);
            groupBox2.TabIndex = 20;
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
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(682, 494);
            button1.Name = "button1";
            button1.Size = new Size(168, 30);
            button1.TabIndex = 24;
            button1.Text = "Manage Library Members";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            BackColor = Color.LightSalmon;
            ClientSize = new Size(933, 576);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lbType);
            Controls.Add(cbType);
            Controls.Add(lbSerial);
            Controls.Add(tbSerial);
            Controls.Add(lbTitle);
            Controls.Add(tbTitle);
            Controls.Add(gbSpellBook);
            Controls.Add(gbRecipeBook);
            Controls.Add(btnAdd);
            Controls.Add(btnDisplay);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Gargmel Library";
            gbSpellBook.ResumeLayout(false);
            gbSpellBook.PerformLayout();
            gbRecipeBook.ResumeLayout(false);
            gbRecipeBook.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbType, lbSerial, lbTitle,lbMagicType, lbNumRecipes;
        private System.Windows.Forms.ComboBox cbType, cbMagicType;
        private System.Windows.Forms.TextBox tbSerial, tbTitle,  tbNumRecipes;
        private System.Windows.Forms.Button btnAdd, btnDisplay;
        private System.Windows.Forms.GroupBox gbSpellBook, gbRecipeBook;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private TextBox tbBiography;
        private TextBox tbName;
        private Button button1;
    }
}