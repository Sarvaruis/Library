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

        [Required]
        [Column("BorrowedBook")]
        public virtual Book BorrowedBook { get; set; }

        [Required]
        [Column("Borrower")]
        public virtual Reader Borrower { get; set; }

        [Required]
        [Column("ReturnDate", TypeName = "Date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
