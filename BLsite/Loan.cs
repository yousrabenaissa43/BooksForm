﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLsite
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        // Clés étrangères
        public int BookId { get; set; }
        public int MemberId { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        // Propriétés de navigation
        [ForeignKey("Id")]
        public virtual Book Book { get; set; }

        [ForeignKey("MemberId")]
        public virtual LibraryMember LibraryMember { get; set; }
    }
}

