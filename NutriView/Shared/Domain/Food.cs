using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        public string? Name { get; set; }

        public double Calories { get; set; }

        public double Carbohydrates { get; set; }

        public string? Vitamins { get; set; }

        public double Fats { get; set; }
        public double ServingSize { get; set; }

        public byte[]? Imagebytes { get; set; }

        public int StaffId { get; set; }

        public string? FoodDesc { get; set; }

        public virtual List<EntryLinkFood>? EntryLinkFood {  get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
