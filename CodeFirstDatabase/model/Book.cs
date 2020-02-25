using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int PubYear { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual BookStorage BookStorage { get; set; }

        public ICollection<Author> Authors { get; set; }

        public Book()
        {
            this.Authors = new HashSet<Author>();
        }
    }
}
