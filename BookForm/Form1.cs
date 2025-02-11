using System;
using System.Windows.Forms;
using BLsite;
using DALsite;

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
            // Get all books from the database
            List<Book> books = LibraryManager.GetAllBooks();

            // Create and show the DisplayForm with the books
            DisplayForm displayForm = new DisplayForm(books);
            displayForm.Show(); // This will show the new form
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Collect the book data from input controls (e.g., textboxes, dropdowns)
            int serial = int.Parse(tbSerial.Text); // Assuming you have a textbox for serial number
            string title = tbTitle.Text;
            int value = int.Parse(tbValue.Text);

            // Check if the type is SpellBook
            if (cbType.SelectedItem == "Spell Book")
            {
                if (cbMagicType.SelectedItem != null) // Assuming a ComboBox for selecting MagicType
                {

                    if (cbMagicType.SelectedItem == "Enchantment")
                    {

                        LibraryManager.AddSpellBook(serial, title, value, MagicType.Enchantment);
                        MessageBox.Show("Book added successfully!");
                    }

                    if (cbMagicType.SelectedItem == "Cruse")
                    {
                        LibraryManager.AddSpellBook(serial, title, value, MagicType.Cruse);
                        MessageBox.Show("Book added successfully!");
                    }
                    if (cbMagicType.SelectedItem == "Transmutation")
                    {
                        LibraryManager.AddSpellBook(serial, title, value, MagicType.Transmutation);
                        MessageBox.Show("Book added successfully!");
                    }
                }
            }
            else //if (cbType.SelectedItem == "Recipe Book")
            {

                LibraryManager.AddRecipeBook(serial, title, value, int.Parse(tbNumRecipes.Text));
                MessageBox.Show("Book added successfully!");

            }


            }

        

        private void button4_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string title = tbBiography.Text;
            LibraryManager.AddAuthor(name, title);
            MessageBox.Show("Author added successfully!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Author> authorList = LibraryManager.GetAuthors();
            DisplayAuthorsForm displayForm = new DisplayAuthorsForm(authorList);
            displayForm.Show();
        }
    }
}

