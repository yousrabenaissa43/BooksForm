using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            LibraryMembers membersForm = new LibraryMembers();
            membersForm.ShowDialog();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            Form1 booksForm = new Form1();
            booksForm.ShowDialog();
        }

        private void btnManageAuthors_Click(object sender, EventArgs e)
        {
           // AuthorsForm authorsForm = new AuthorsForm();
           // authorsForm.ShowDialog();
        }
    }
}
