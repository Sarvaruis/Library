using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Readers")]
    public class Reader
    {
        [Key]
        public int ReaderId { get; set; }

        [Required]
        [Display(Name = nameof(Name))]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = nameof(Surname))]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [Display(Name = nameof(Penalty))]
        public int Penalty { get; set; }

        [Display(Name = nameof(PhoneNumber))]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = nameof(Adress))]
        public virtual Address Adress { get; set; }

        [Required]
        [Display(Name = nameof(UserAccount))]
        public virtual User UserAccount { get; set; }
    }
}
