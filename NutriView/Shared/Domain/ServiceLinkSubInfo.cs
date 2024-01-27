using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class ServiceLinkSubInfo : BaseDomainModel
    {
        public int SubscriptionInfoID { get; set; }
        public virtual SubscriptionInfo? SubscriptionInfo { get; set; }

        public int ServiceID { get; set; }
        public virtual Service? Service { get; set; }
    }
}
