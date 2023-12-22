using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class FoodEntry : BaseDomainModel
    {
        public double TotalCalories { get; set; }

        public string? Time_Stamp { get; set; }

        public int CustomerID { get; set; }

        public virtual List<Food>? Foods { get; set; }

        public virtual List<Meal>? Meals { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
