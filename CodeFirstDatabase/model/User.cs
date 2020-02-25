using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [MaxLength(50)]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
