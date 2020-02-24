using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    public enum RoleEnum
    {
        Reader,
        Librarian,
        DatabaseAdministrator
    }

    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID {get;set;}
        [Required]
        [Column("Login")]
        [MaxLength(50)]
        public string UserLogin { get; set; }
        [Required]
        [Column("Password")]
        [MaxLength(50)]
        public string UserPassword { get; set; }
        [Required]
        [Column("RoleEnum")]
        public RoleEnum Role { get; set; }
        [Required]
        [Column("RoleId")]
        public int RoleID { get; set; }
    }
}
