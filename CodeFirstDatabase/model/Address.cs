using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [MaxLength(6)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string CityName { get; set; }

        [MaxLength(50)]
        public string StreetName { get; set; }
    }
}
