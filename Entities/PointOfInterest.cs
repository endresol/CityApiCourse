using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CityApi.Models;

namespace CityApi.Entities
{
    public class PointsOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } 
        
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}