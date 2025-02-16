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

namespace BookForm
{
    public partial class DisplayLoans : Form
    {
        public DisplayLoans(List<Loan> Loans)
        {
            InitializeComponent();
            lstLoans.Items.Clear();

            // Add each book to the ListBox
            foreach (var loan in Loans)
            {


                // Add the book details to the ListBox
                lstLoans.Items.Add(loan.getInfos());
            }
        }

        
    }
}
