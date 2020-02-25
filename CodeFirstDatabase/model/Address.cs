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
        [Display(Name = nameof(ZipCode))]
        [MaxLength(6)]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = nameof(CityName))]
        [MaxLength(50)]
        public string CityName { get; set; }

        [Display(Name = nameof(StreetName))]
        [MaxLength(50)]
        public string StreetName { get; set; }
    }
}
