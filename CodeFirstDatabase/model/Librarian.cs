using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Librarians")]
    public class Librarian
    {
        [Key]
        public int LibrarianId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        public int Salary { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public virtual Address Address { get; set; }

        public virtual User UserAccount { get; set; }
    }
}
