using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NutriView.Shared.Domain
{
    public class Food : BaseDomainModel, IValidatableObject
    {
        [Required(ErrorMessage = "The name of the food is required.")]
        [StringLength(200, ErrorMessage = "The name must be less than 200 characters long.")]
        public string Name { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Calories must be a positive number.")]
        public double Calories { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Carbohydrates must be a positive number.")]
        public double Carbohydrates { get; set; }

        public string? Vitamins { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Fats must be a positive number.")]
        public double Fats { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Serving size must be a positive number.")]
        public double ServingSize { get; set; }

        public byte[]? Imagebytes { get; set; }

        public int StaffId { get; set; }
        [StringLength(1000, ErrorMessage = "Food description must be less than 1000 characters.")]
        public string? FoodDesc { get; set; }

        public virtual List<EntryLinkFood>? EntryLinkFood {  get; set; }
        public virtual Staff? Staff { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
