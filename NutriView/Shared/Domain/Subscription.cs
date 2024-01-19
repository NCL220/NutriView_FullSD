using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        public double Cost { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int CustomerID { get; set; }
        
        public int SubInfoID { get; set; }
        public virtual SubscriptionInfo? SubscriptionInfo { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
