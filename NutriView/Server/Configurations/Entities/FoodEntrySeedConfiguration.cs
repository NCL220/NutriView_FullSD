using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class FoodEntrySeedConfiguration : IEntityTypeConfiguration<FoodEntry>
    {
        public void Configure(EntityTypeBuilder<FoodEntry> builder)
        {
            builder.HasData(
            new FoodEntry
            {
                Id = 1,
                CustomerID = 1,
                TotalCalories=22,
                Time_Stamp= DateTime.Now,
                DateCreated= DateTime.Now,
                DateUpdated= DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new FoodEntry
            {
                Id = 2,
                CustomerID = 2,
                TotalCalories = 34,
                Time_Stamp = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
           );

        }
    }
}
