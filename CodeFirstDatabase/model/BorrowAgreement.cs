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
        [Display(Name = nameof(BorrowedBook))]
        public virtual Book BorrowedBook { get; set; }

        [Required]
        [Display(Name = nameof(Borrower))]
        public virtual Reader Borrower { get; set; }

        [Required]
        [Display(Name = nameof(ReturnDate))]
        [Column(TypeName = "Date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Display(Name = nameof(IsActive))]
        public bool IsActive { get; set; }
    }
}
