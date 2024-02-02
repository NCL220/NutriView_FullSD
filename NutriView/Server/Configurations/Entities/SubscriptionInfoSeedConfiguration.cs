using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriView.Shared.Domain;
using System.Drawing;

namespace NutriView.Server.Configurations.Entities
{
    public class SubscriptionInfoSeedConfiguration : IEntityTypeConfiguration<SubscriptionInfo>
    {
        public void Configure(EntityTypeBuilder<SubscriptionInfo> builder)
        {
            builder.HasData(
             new SubscriptionInfo
             {
                 Id = 1,
                 SubDescription = "Unlocks The Personal Quota With Food Entries Submission!!",
                 SubCost = 40.0,
                 SubTierName = "Health Enthusiasts (Tier 3)",
                 SubType = "Monthly",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new SubscriptionInfo
             {
                 Id = 2,
                 SubDescription = "Unlocks The Food Entries Submission!!",
                 SubCost = 25.0,
                 SubTierName = "Food Enthusiasts (Tier 2)",
                 SubType = "Yearly",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new SubscriptionInfo
             {
                 Id = 3,
                 SubDescription = "Unlocks The Personal Quota Tracker!!",
                 SubCost = 25.0,
                 SubTierName = "Nutritional Enthusiasts (Tier 1)",
                 SubType = "Yearly",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            ); ;
        }
    }
}
