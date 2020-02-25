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
        [Display(Name = nameof(Book))]
        public virtual Book Book { get; set; }

        [Required]
        [Display(Name = nameof(Author))]
        public virtual Author Author { get; set; }     
    }
}
