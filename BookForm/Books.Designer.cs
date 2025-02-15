namespace BookForm
{
    partial class Books
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
            gbSpellBook.SuspendLayout();
            gbRecipeBook.SuspendLayout();
            SuspendLayout();
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.BackColor = Color.Transparent;
            lbType.ForeColor = SystemColors.Control;
            lbType.Location = new Point(30, 30);
            lbType.Name = "lbType";
            lbType.Size = new Size(47, 20);
            lbType.TabIndex = 0;
            lbType.Text = "Type :";
            // 
            // lbSerial
            // 
            lbSerial.AutoSize = true;
            lbSerial.BackColor = Color.Transparent;
            lbSerial.ForeColor = SystemColors.Control;
            lbSerial.Location = new Point(30, 70);
            lbSerial.Name = "lbSerial";
            lbSerial.Size = new Size(53, 20);
            lbSerial.TabIndex = 2;
            lbSerial.Text = "Serial :";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.ForeColor = SystemColors.Control;
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
            gbSpellBook.BackColor = Color.Transparent;
            gbSpellBook.Controls.Add(lbMagicType);
            gbSpellBook.Controls.Add(cbMagicType);
            gbSpellBook.ForeColor = SystemColors.ButtonHighlight;
            gbSpellBook.Location = new Point(300, 20);
            gbSpellBook.Name = "gbSpellBook";
            gbSpellBook.Size = new Size(250, 80);
            gbSpellBook.TabIndex = 8;
            gbSpellBook.TabStop = false;
            gbSpellBook.Text = "Spell Book";
            // 
            // gbRecipeBook
            // 
            gbRecipeBook.BackColor = Color.Transparent;
            gbRecipeBook.Controls.Add(lbNumRecipes);
            gbRecipeBook.Controls.Add(tbNumRecipes);
            gbRecipeBook.ForeColor = SystemColors.ButtonHighlight;
            gbRecipeBook.Location = new Point(300, 124);
            gbRecipeBook.Name = "gbRecipeBook";
            gbRecipeBook.Size = new Size(250, 80);
            gbRecipeBook.TabIndex = 9;
            gbRecipeBook.TabStop = false;
            gbRecipeBook.Text = "Recipe Book";
            // 
            // Books
            // 
            BackColor = Color.LightSalmon;
            BackgroundImage = Properties.Resources.books;
            ClientSize = new Size(649, 383);
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
            Name = "Books";
            RightToLeft = RightToLeft.No;
            Text = "Gargmel Library";
            gbSpellBook.ResumeLayout(false);
            gbSpellBook.PerformLayout();
            gbRecipeBook.ResumeLayout(false);
            gbRecipeBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbType, lbSerial, lbTitle,lbMagicType, lbNumRecipes;
        private System.Windows.Forms.ComboBox cbType, cbMagicType;
        private System.Windows.Forms.TextBox tbSerial, tbTitle,  tbNumRecipes;
        private System.Windows.Forms.Button btnAdd, btnDisplay;
        private System.Windows.Forms.GroupBox gbSpellBook, gbRecipeBook;
    }
}