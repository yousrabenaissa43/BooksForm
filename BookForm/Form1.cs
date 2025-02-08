using System;
using System.Windows.Forms;

namespace BookForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Disable both initially
            cbMagicType.Enabled = false;
            tbNumRecipes.Enabled = false;

            // Attach event handler for selection change
            cbType.SelectedIndexChanged += CbType_SelectedIndexChanged;
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem != null)
            {
                string selectedType = cbType.SelectedItem.ToString();

                if (selectedType == "Spell Book")
                {
                    cbMagicType.Enabled = true;
                    tbNumRecipes.Enabled = false;
                }
                else if (selectedType == "Recipe Book")
                {
                    cbMagicType.Enabled = false;
                    tbNumRecipes.Enabled = true;
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Get common attributes
            string type = cbType.SelectedItem?.ToString() ?? "";
            string serial = tbSerial.Text;
            string title = tbTitle.Text;
            string value = tbValue.Text;

            string magicType = "";
            string numRecipes = "";

            // Check book type and retrieve the correct additional attribute
            if (type == "SpellBook")
            {
                magicType = cbMagicType.SelectedItem?.ToString() ?? "";
            }
            else if (type == "RecipeBook")
            {
                numRecipes = tbNumRecipes.Text;
            }

            // Open DisplayForm and pass the book details
            DisplayForm displayForm = new DisplayForm(type, serial, title, value, magicType, numRecipes);
            displayForm.ShowDialog(); // Show as a modal dialog
        }

    }
}
