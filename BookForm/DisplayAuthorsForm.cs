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
using static System.Reflection.Metadata.BlobBuilder;

namespace BookForm
{
    public partial class DisplayAuthorsForm : Form
    {
        public DisplayAuthorsForm(List<Author> Authors)
        {
            InitializeComponent();
            // Clear any existing items in the ListBox
            lstAuthors.Items.Clear();

            // Add each book to the ListBox
            foreach (var book in Authors)
            {


                // Add the book details to the ListBox
                lstAuthors.Items.Add(book.getInfos());
            }
        }
    }
}
