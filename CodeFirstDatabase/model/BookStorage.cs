using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("BookStorages")]
    public class BookStorage
    {
        public BookStorage()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int BookStorageID { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string BookStorageName { get; set; }
        [Column("Books")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
