using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("DbAdmins")]
    public class DatabaseAdministrator
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [Display(Name = nameof(Name))]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = nameof(Surname))]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [Display(Name = nameof(PhoneNumber))]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = nameof(UserAccount))]
        public virtual User UserAccount { get; set; }
    }
}
