using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class NutritionInfo : BaseDomainModel
    {
        public string? NutritionName { get; set; }

        public string? NutritionDescription { get; set; }

        public string? NutritionImagePath { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        }
}
