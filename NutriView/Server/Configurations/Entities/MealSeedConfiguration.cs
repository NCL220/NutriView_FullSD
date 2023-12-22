using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class MealSeedConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
             new Meal
             {
                 Id = 1,
                 FoodEntryID = 1,
                 Name = "Carrots",
                 PortionSize = 1,
                 TimePeriod = "Morning",
                 DateCreated = DateTime.UtcNow,
                 DateUpdated = DateTime.UtcNow,
                 CreatedBy = "System",
                 UpdatedBy = "System"

             },
             new Meal
             {
                 Id = 2,
                 FoodEntryID = 2,
                 Name = "ChickenRice",
                 PortionSize = 1,
                 TimePeriod = "Morning",
                 DateCreated = DateTime.UtcNow,
                 DateUpdated = DateTime.UtcNow,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );
        }
    }
}
