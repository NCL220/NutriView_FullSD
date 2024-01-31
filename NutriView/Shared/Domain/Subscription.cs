using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        [Range(0, double.MaxValue, ErrorMessage = "Cost must be a non-negative number.")]
        public double Cost { get; set; }
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int CustomerID { get; set; }
        
        public int SubInfoID { get; set; }
        public virtual SubscriptionInfo? SubscriptionInfo { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
