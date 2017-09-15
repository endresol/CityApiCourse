using System.ComponentModel.DataAnnotations;

namespace CityApi.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage="Navn er obligatorisk")]
        [MaxLength(50)]
        public string Name { get; set; } 
        
        [MaxLength(200)]
        public string Description { get; set; }
    }
    
}