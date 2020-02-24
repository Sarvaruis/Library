using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Genres")]
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int GenreId { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string GenreName { get; set; }
        [Column("Books")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
