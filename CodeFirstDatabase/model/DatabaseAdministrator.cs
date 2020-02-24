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
        [Column("Name")]
        [MaxLength(50)]
        public string AdminName { get; set; }
        [Required]
        [Column("Surname")]
        [MaxLength(50)]
        public string AdminSurname { get; set; }
        [Required]
        [Column("PhoneNumber")]
        [MaxLength(15)]
        public string AdminPhoneNumber { get; set; }
        [Required]
        [Column("UserAccount")]
        public virtual User UserAccount { get; set; }
    }
}
