using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Meal : BaseDomainModel
    {
        public string? Name { get; set; }

        public int? Calories { get; set; }

        public double? PortionSize { get; set; }

        public string? TimePeriod { get; set; }

        public int FoodEntryID { get; set; }
        
        public virtual FoodEntry? FoodEntry { get; set; }
    }
}
