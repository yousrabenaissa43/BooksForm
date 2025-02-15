using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALsite;

namespace BookForm
{
    public partial class LibraryMembers : Form
    {
        public LibraryMembers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbFullName.Text;
            string email = tbEmail.Text;

            LibraryManager.AddLibraryMember(name, email);
            MessageBox.Show("Library Member added successfully!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiplayFormLibMembers diplay = new DiplayFormLibMembers(LibraryManager.GetLibraryMembers());
            diplay.Show();
        }
    }
}
