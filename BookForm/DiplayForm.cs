using System;
using System.Windows.Forms;
using BLsite;

namespace BookForm
{
    public partial class DisplayForm : Form
    {
        public DisplayForm(List<Book> books)
        {
            InitializeComponent();

            // Clear any existing items in the ListBox
            lstBooks.Items.Clear();

            // Add each book to the ListBox
            foreach (var book in books)
            {
               

                // Add the book details to the ListBox
                lstBooks.Items.Add(book.GetExtandedInfos());
            }
        }
    }
}
