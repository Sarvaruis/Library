using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Librarians")]
    public class Librarian
    {
        [Key]
        public int LibrarianId { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string LibrarianName { get; set; }
        [Required]
        [Column("Surname")]
        [MaxLength(50)]
        public string LibrarianSurname { get; set; }
        [Required]
        [Column("Salary")]
        public int LibrarianSalary { get; set; }
        [Required]
        [Column("Address")]
        public virtual Address LibrarianAdress { get; set; }
        [Required]
        [Column("PhoneNumber")]
        [MaxLength(15)]
        public string LibrarianPhoneNumber { get; set; }
        [Required]
        [Column("UserAccount")]
        public virtual User UserAccount { get; set; }
    }
}
