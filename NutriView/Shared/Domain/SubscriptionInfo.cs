using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class SubscriptionInfo : BaseDomainModel
    {
        public string? SubDescription { get; set; }

        public double SubCost { get; set; }

        public string? SubTierName { get; set; }

        public string? SubType {  get; set; }

        public int? SubMonthsDuration { get; set; }
    }
}
