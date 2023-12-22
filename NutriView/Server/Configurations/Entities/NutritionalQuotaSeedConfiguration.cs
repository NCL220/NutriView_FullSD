using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class NutritionalQuotaSeedConfiguration : IEntityTypeConfiguration<NutritionalQuota>
    {
        public void Configure(EntityTypeBuilder<NutritionalQuota> builder)
        {
            builder.HasData(
             new NutritionalQuota
             {
                 Id = 1,
                 CustomerID = 1,
                 TargetBMI = 19,
                 TargetCalorieDaily = 2000,
                 TargetCarbDaily = 300,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new NutritionalQuota
             {
                 Id = 2,
                 CustomerID = 2,
                 TargetBMI = 21,
                 TargetCalorieDaily = 2000,
                 TargetCarbDaily = 290,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );
        }
    }
}
