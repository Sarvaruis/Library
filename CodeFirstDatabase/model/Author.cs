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

        [Required]
        [Display(Name = nameof(Name))]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = nameof(Surname))]
        [MaxLength(50)]
        public string Surname { get; set; }
    }
}
