
using System.ComponentModel.DataAnnotations;
namespace MegaDeskWeb.Models
{
    public class Material
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Description { get; set; }

        [Range(0, 50000)]
        public double Amount { get; set; }

    }
}
