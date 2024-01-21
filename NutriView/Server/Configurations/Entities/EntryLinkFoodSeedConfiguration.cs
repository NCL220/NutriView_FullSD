using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class EntryLinkFoodSeedConfiguration : IEntityTypeConfiguration<EntryLinkFood>
    {
        public void Configure(EntityTypeBuilder<EntryLinkFood> builder)
        {
            builder.HasData(
             new EntryLinkFood
             {
                 Id = 1,
                 FoodEntryID=2,
                 FoodID=2
                 
             },
             new EntryLinkFood
             {
                 Id = 2,
                 FoodEntryID = 1,
                 FoodID = 1
             }
            );
        }
    }
}
