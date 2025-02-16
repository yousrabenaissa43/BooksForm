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
using Microsoft.EntityFrameworkCore;

namespace BookForm
{
    public partial class LoanForm : Form
    {
        private LibraryContext _context = new LibraryContext(); // Your EF DbContext
        public LoanForm()
        {
            InitializeComponent();
            LoadBooks();
            LoadMembers();
        }

        //load books in the combobox 
        private void LoadBooks()
        {
            var recipeBooks = _context.RecipeBooks
                              .Select(b => new { b.Id, Title = "Recipe Book: " + b.Title })
                              .ToList();

            var spellBooks = _context.SpellBooks
                                     .Select(b => new { b.Id, Title = "Spell Book: " + b.Title })
                                     .ToList();

            // Merge both lists
            var allBooks = recipeBooks.Concat(spellBooks).ToList();

            // Bind to ComboBox
            cmbBooks.DataSource = allBooks;
            cmbBooks.DisplayMember = "Title";  // User sees "Recipe: BookName" or "Spell: BookName"
            cmbBooks.ValueMember = "Id";   // Internal value remains the BookId
        }
        //load lib members in the combobox 
        private void LoadMembers()
        {
            var members = _context.LibraryMembers
                                  .Select(m => new { Id = m.MemberId, Name = m.FullName })
                                  .ToList();

            // Debug to verify data
            if (members.Count == 0)
            {
                MessageBox.Show("No library members found in the database.");
                return;
            }

            // Bind to ComboBox
            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "Name";  // What user sees
            cmbMembers.ValueMember = "Id";      // Internal value used
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
