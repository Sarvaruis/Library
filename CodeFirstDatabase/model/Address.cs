using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        [Column("ZipCode")]
        [MaxLength(6)]
        public string ZipCode { get; set; }
        [Required]
        [Column("CityName")]
        [MaxLength(50)]
        public string CityName { get; set; }
        [Column("StreetName")]
        [MaxLength(50)]
        public string StreetName { get; set; }
    }
}
