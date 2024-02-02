using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using Microsoft.VisualBasic;

namespace NutriView.Server.Configurations.Entities
{
    public class SubscriptionSeedConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasData(
            new Subscription
            {
                Id= 1,
                CustomerID= 1,
                SubInfoID= 1,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Subscription
            {
                CustomerID= 2,
                Id = 2,
                SubInfoID = 2,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Subscription
            {
                CustomerID = 3,
                Id = 3,
                SubInfoID = 3,
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
           );

        }
    }
}