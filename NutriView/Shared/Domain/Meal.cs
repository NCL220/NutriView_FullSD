using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Meal : BaseDomainModel
    {
        [Required(ErrorMessage = "Meal nae is required.")]
        [StringLength(200, ErrorMessage = "Meal name must be less than 200 characters.")]
        public string Name { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Calories must be a non-negative number.")]
        public double Calories { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Portion size must be a non-negative number.")]
        public double? PortionSize { get; set; }
        [StringLength(100, ErrorMessage = "Time period must be less than 100 characters.")]
        public string? TimePeriod { get; set; }
        [Required(ErrorMessage = "Food entry ID is required.")]
        public int FoodEntryID { get; set; }
        
        public virtual FoodEntry? FoodEntry { get; set; }

    }
}
