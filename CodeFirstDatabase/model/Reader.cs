using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Readers")]
    public class Reader
    {
        public Reader()
        {
            this.BorrowAgreements = new HashSet<BorrowAgreement>();
        }

        [Key]
        public int ReaderId { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string ReaderName { get; set; }
        [Required]
        [Column("Surname")]
        [MaxLength(50)]
        public string ReaderSurname { get; set; }
        [Required]
        [Column("Penalty")]
        public int ReaderPenalty { get; set; }
        [Required]
        [Column("Address")]
        public virtual Address ReaderAdress { get; set; }
        [Column("PhoneNumber")]
        [MaxLength(15)]
        public string ReaderPhoneNumber { get; set; }
        [Required]
        [Column("UserAccount")]
        public virtual User UserAccount { get; set; }
        [Column("BorrowAgreements")]
        public virtual ICollection<BorrowAgreement> BorrowAgreements { get; set; }
    }
}
