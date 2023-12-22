using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class NutritionalQuota : BaseDomainModel
    {
        public double TargetCalorieDaily { get; set; }

        public double TargetCarbDaily { get; set; }

        public double TargetBMI { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
