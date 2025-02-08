using System;
using System.Windows.Forms;

namespace BookForm
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(string type, string serial, string title, string value, string magicType, string numRecipes)
        {
            InitializeComponent();

            Label lblType = new Label { Text = "Type: " + type, AutoSize = true, Location = new System.Drawing.Point(20, 20) };
            Label lblSerial = new Label { Text = "Serial: " + serial, AutoSize = true, Location = new System.Drawing.Point(20, 50) };
            Label lblTitle = new Label { Text = "Title: " + title, AutoSize = true, Location = new System.Drawing.Point(20, 80) };
            Label lblValue = new Label { Text = "Value: " + value, AutoSize = true, Location = new System.Drawing.Point(20, 110) };

            this.Controls.Add(lblType);
            this.Controls.Add(lblSerial);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblValue);

            if (type == "SpellBook")
            {
                Label lblMagicType = new Label { Text = "Magic Type: " + magicType, AutoSize = true, Location = new System.Drawing.Point(20, 140) };
                this.Controls.Add(lblMagicType);
            }
            else if (type == "RecipeBook")
            {
                Label lblNumRecipes = new Label { Text = "Number of Recipes: " + numRecipes, AutoSize = true, Location = new System.Drawing.Point(20, 140) };
                this.Controls.Add(lblNumRecipes);
            }
        }
    }
}
