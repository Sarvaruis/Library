using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        public ICollection<Book> Books { get; set; }

        public Author()
        {
            this.Books = new HashSet<Book>();
        }
    }
}
