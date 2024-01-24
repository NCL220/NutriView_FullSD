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
                 SubDescription = "Unlocks The Personal Quota Tracker",
                 SubCost = 5.0,
                 SubTierName = "Health Enthusiasts",
                 SubType = "Monthly",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new SubscriptionInfo
             {
                 Id = 2,
                 SubDescription = "Unlocks The Personal Quota Tracker and other Features!!",
                 SubCost = 30.0,
                 SubTierName = "Health Enthusiasts",
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
