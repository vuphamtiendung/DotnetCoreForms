using System.ComponentModel.DataAnnotations;

namespace DotnetCoreForms_004.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "Length must be between 5 to 100")]
        public string Name { get; set; }    
        public double Rate { get; set; }
        public int Rating { get; set; } 
    }
}
