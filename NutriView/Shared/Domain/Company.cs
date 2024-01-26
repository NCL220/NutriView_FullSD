using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Company : BaseDomainModel
    {
        public string? Mission { get; set; }

        public string? CompanyDescription { get; set; }

        public byte[]? CompanyImageByte { get; set; }
        public string? CompanyName { get; set; }

        public virtual List<Staff>? Staffs { get; set;}
    }
}
