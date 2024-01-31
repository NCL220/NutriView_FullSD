using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class FoodEntry : BaseDomainModel, IValidatableObject
    {
        [Range(0, double.MaxValue, ErrorMessage = "Total calories must be a non-negative number.")]
        public double TotalCalories { get; set; }
        [Required(ErrorMessage = "Time stamp is required.")]
        public DateTime Time_Stamp { get; set; }
        [Required(ErrorMessage = "Customer ID is required.")]
        public int CustomerID { get; set; }

        public virtual List<EntryLinkFood>? EntryLinkFood { get; set; }

        public virtual List<Meal>? Meals { get; set; }

        public virtual Customer? Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
