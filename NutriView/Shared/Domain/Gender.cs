using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Gender : BaseDomainModel
    {

        public string Name { get; set; }

        public virtual List<Customer>? Customers { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
