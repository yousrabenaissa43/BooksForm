using System;
using System.Windows.Forms;
using BLsite;
using DALsite;
using Microsoft.EntityFrameworkCore;

namespace BookForm
{
    public partial class Books : Form
    {
        private LibraryContext _context = new LibraryContext(); // Your EF DbContext
        public Books()
        {
            InitializeComponent();

            // Disable both initially
            cbMagicType.Enabled = false;
            tbNumRecipes.Enabled = false;
            LoadAuthors();

            // Attach event handler for selection change
            cbType.SelectedIndexChanged += CbType_SelectedIndexChanged;
        }
        private void LoadAuthors()
        {
            var authors = _context.Authors
                                  .Select(a => new
                                  {
                                      a.AuthorId,
                                      FullDisplay = a.Name + " - " + a.Biography
                                  })
                                  .ToList();

            // Vérifier si des auteurs existent
            if (authors.Count == 0)
            {
                MessageBox.Show("Aucun auteur trouvé dans la base de données.");
                return;
            }

            // Liaison avec le ComboBox
            cmbAuthors.DataSource = authors;
            cmbAuthors.DisplayMember = "FullDisplay";  // Affiche "Nom - Biographie"
            cmbAuthors.ValueMember = "AuthorId";       // Valeur interne utilisée
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
            // Validate and parse Serial Number
            if (!int.TryParse(tbSerial.Text, out int serial))
            {
                MessageBox.Show("Invalid serial number!");
                return;
            }

            string title = tbTitle.Text;

            // Get the selected Author from the ComboBox
            if (cmbAuthors.SelectedItem is Author selectedAuthor)
            {
                int authorId = selectedAuthor.AuthorId; // Extract Author ID

                // Check if the selected type is "Spell Book"
                if (cbType.SelectedItem?.ToString() == "Spell Book")
                {
                    if (cbMagicType.SelectedItem != null)
                    {
                        MagicType magicType;

                        switch (cbMagicType.SelectedItem.ToString())
                        {
                            case "Enchantment":
                                magicType = MagicType.Enchantment;
                                break;
                            case "Cruse":
                                magicType = MagicType.Cruse;
                                break;
                            case "Transmutation":
                                magicType = MagicType.Transmutation;
                                break;
                            default:
                                MessageBox.Show("Invalid magic type selected!");
                                return;
                        }

                        // Add SpellBook with Author ID
                        LibraryManager.AddSpellBook(serial, title, magicType, authorId);
                        MessageBox.Show("Spell Book added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please select a magic type!");
                    }
                }
                else // If it's a "Recipe Book"
                {
                    if (!int.TryParse(tbNumRecipes.Text, out int numRecipes))
                    {
                        MessageBox.Show("Invalid number of recipes!");
                        return;
                    }

                    // Add RecipeBook with Author ID
                    LibraryManager.AddRecipeBook(serial, title, numRecipes, authorId);
                    MessageBox.Show("Recipe Book added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select an author!");
            }
        }

       
    }
}

