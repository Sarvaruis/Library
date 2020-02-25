using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("BorrowAgreementents")]
    public class BorrowAgreement
    {
        [Key]
        public int BorrowAgreementId { get; set; }

        public virtual Book BorrowedBook { get; set; }

        public virtual Reader Borrower { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReturnDate { get; set; }

        public bool IsActive { get; set; }
    }
}
