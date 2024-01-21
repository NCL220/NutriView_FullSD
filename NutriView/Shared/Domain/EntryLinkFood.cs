using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class EntryLinkFood : BaseDomainModel
    {
        public int FoodEntryID { get; set; }
        public virtual FoodEntry? FoodEntry { get; set; }
        
        public int FoodID { get; set; }
        public virtual Food? Food { get; set; }
    }
}
