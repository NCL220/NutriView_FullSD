using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class SubscriptionInfo : BaseDomainModel
    {
        [StringLength(1000, ErrorMessage = "Subscription description must be less than 1000 characters.")]
        public string? SubDescription { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Subscription cost must be a non-negative number.")]
        public double SubCost { get; set; }
        [StringLength(100, ErrorMessage = "Subscription tier name must be less than 100 characters.")]
        public string? SubTierName { get; set; }
        [StringLength(100, ErrorMessage = "Subscription type must be less than 100 characters.")]
        public string? SubType {  get; set; }

        public int SubMonthsDuration { get; set; }

        public virtual List<ServiceLinkSubInfo>? ServiceLinkSubInfos { get; set; }
    }
}
