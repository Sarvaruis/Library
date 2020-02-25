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

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        public int Penalty { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public virtual Address Adress { get; set; }

        public virtual User UserAccount { get; set; }
    }
}
