using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? UserName { get; set; }

        public string? Role { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public int? PhoneNumber { get; set; }

        public string? ImagePathStaff { get; set; }

        public byte[]? ImageByte { get; set; }
        public virtual List<NutritionInfo>? NutritionInfos { get; set; }
        public virtual List<Food>? Foods { get; set; }

        public int? ManagerID { get; set; }

        public int CompanyId {  get; set; }
        public virtual Company? Company { get; set; }

        
    }
}
