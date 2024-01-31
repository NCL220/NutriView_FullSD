using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class NutritionalQuota : BaseDomainModel
    {
        [Range(0, double.MaxValue, ErrorMessage = "Target Calories must be a non-negative number.")]
        public double TargetCalorieDaily { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Target Carbohydrates must be a non-negative number.")]
        public double TargetCarbDaily { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Target BMI must be a non-negative number.")]
        public double TargetBMI { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
