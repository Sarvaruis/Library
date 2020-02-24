using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Books")]
    public class Book
    {
        public Book()
        {
            this.AuthorsRef = new HashSet<BookAuthor>();
            this.BorrowAgreements = new HashSet<BorrowAgreement>();
        }
        [Key]
        public int BookID { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string BookName { get; set; }
        [Required]
        [Column("PublicationYear")]
        public int BookPubYear { get; set; }
        [Required]
        [Column("Genre")]
        public virtual Genre BookGenre { get; set; }
        [Required]
        [Column("AuthorsRef")]
        public virtual ICollection<BookAuthor> AuthorsRef { get; set; }
        [Required]
        [Column("BookStorage")]
        public virtual BookStorage BookStorage { get; set; }
        [Column("BorrowAgreements")]
        public virtual ICollection<BorrowAgreement> BorrowAgreements { get; set; }
    }
}
