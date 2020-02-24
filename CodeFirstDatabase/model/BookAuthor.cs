using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("BooksAuthors")]
    public class BookAuthor
    {
        [Key]
        public int BookAuthorId { get; set; }

        [Required]
        [Column("BookRef")]
        public virtual Book Book { get; set; }

        [Required]
        [Column("AuthorRef")]
        public virtual Author Author { get; set; }     
    }
}
