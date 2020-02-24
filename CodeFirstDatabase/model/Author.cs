using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Authors")]
    public class Author
    {
        public Author()
        {
            this.BooksRef = new HashSet<BookAuthor>();
        }
        [Key]
        public int AuthorID { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string AuthorName { get; set; }
        [Required]
        [Column("Surname")]
        [MaxLength(50)]
        public string AuthorSurname { get; set; }
        [Column("BooksRef")]
        public virtual ICollection<BookAuthor> BooksRef { get; set; }
    }
}
