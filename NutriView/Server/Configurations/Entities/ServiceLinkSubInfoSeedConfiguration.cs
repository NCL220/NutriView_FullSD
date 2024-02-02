using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class ServiceLinkSubInfoSeedConfiguration : IEntityTypeConfiguration<ServiceLinkSubInfo>
    {
        public void Configure(EntityTypeBuilder<ServiceLinkSubInfo> builder)
        {
            builder.HasData(
             new ServiceLinkSubInfo
             {
                 Id = 1,
                 SubscriptionInfoID = 1,
                 ServiceID= 1

             },
             new ServiceLinkSubInfo
             {
                 Id = 2,
                 SubscriptionInfoID = 1,
                 ServiceID = 2
             },
             new ServiceLinkSubInfo
             {
                 Id = 3,
                 SubscriptionInfoID = 2,
                 ServiceID = 1

             },
             new ServiceLinkSubInfo
             {
                 Id = 4,
                 SubscriptionInfoID = 3,
                 ServiceID = 2

             }
            );
        }
    }
}
