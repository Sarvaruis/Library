using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("DbAdmins")]
    public class DatabaseAdministrator
    {
        [Key]
        public int AdminId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public virtual User UserAccount { get; set; }
    }
}
