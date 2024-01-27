using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Service : BaseDomainModel
    {
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }

        public virtual List<ServiceLinkSubInfo>? ServiceLinkSubInfos { get; set; }
    }
}
