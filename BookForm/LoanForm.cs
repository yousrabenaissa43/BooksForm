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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect data from form fields
            int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            int memberId = Convert.ToInt32(cmbMembers.SelectedValue);
            DateTime loanDate = DateTime.Now;
            DateTime dueDate = loanDate.AddDays(14); // Default loan period: 14 days

            // Save to database 
            LibraryManager.AddLoan(bookId, memberId, loanDate, dueDate);
            MessageBox.Show("Loan registered successfully!", "Success");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<Loan> LoansList = LibraryManager.GetLoans();
            DisplayLoans displayForm = new DisplayLoans(LoansList);
            displayForm.Show();
        }
       
    }
}
