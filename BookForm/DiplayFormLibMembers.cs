using System;
using System.Windows.Forms;
using BLsite;

namespace BookForm
{
    public partial class DiplayFormLibMembers : Form
    {
        public DiplayFormLibMembers(List<LibraryMember> libraryMembers)
        {
            InitializeComponent();

            // Clear any existing items in the ListBox
            lstLibMembers.Items.Clear();

            // Add each book to the ListBox
            foreach (var libraryMember in libraryMembers)
            {


                // Add the book details to the ListBox
                lstLibMembers.Items.Add(libraryMember.GetInfos());
            }
        }
    }
}
