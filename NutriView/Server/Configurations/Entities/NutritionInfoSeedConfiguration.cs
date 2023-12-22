
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class NutritionInfoSeedConfiguration : IEntityTypeConfiguration<NutritionInfo>
    {
        public void Configure(EntityTypeBuilder<NutritionInfo> builder)
        {
            builder.HasData(
             new NutritionInfo
             {
                 Id = 1,
                 StaffId = 1,
                 NutritionName="Vitamin A",
                 NutritionDescription= "Essential for vision, immune function, and skin health.",
                 NutritionImagePath="-",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new NutritionInfo
             {
                 Id=2,
                 StaffId=2,
                 NutritionName = "Vitamin D",
                 NutritionDescription = "Supports bone health, immune system, and overall well-being.",
                 NutritionImagePath = "-",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );

        }
    }
}