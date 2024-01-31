using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class NutritionInfo : BaseDomainModel
    {
        [Required(ErrorMessage = "Nutrition name is required.")]
        [StringLength(200, ErrorMessage = "Nutrition name must be less than 200 characters.")]
        public string NutritionName { get; set; }
        [StringLength(1000, ErrorMessage = "Nutrition description must be less than 1000 characters.")]
        public string? NutritionDescription { get; set; }

        public string? NutritionImagePath { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        }
}
