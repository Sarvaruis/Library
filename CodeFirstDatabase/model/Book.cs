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

        [Required]
        [Display(Name = nameof(Name))]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = nameof(PubYear))]
        public int PubYear { get; set; }

        [Required]
        [Display(Name = nameof(Genre))]
        public virtual Genre Genre { get; set; }

        [Required]
        [Display(Name = nameof(BookStorage))]
        public virtual BookStorage BookStorage { get; set; }
    }
}
