using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLsite;
using DALsite;

namespace BookForm
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            List<Author> authorList = LibraryManager.GetAuthors();
            DisplayAuthorsForm displayForm = new DisplayAuthorsForm(authorList);
            displayForm.Show();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string title = tbBiography.Text;
            LibraryManager.AddAuthor(name, title);
            MessageBox.Show("Author added successfully!");
        }
    }
}
