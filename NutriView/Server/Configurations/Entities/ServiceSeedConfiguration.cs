using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class ServiceSeedConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData(
             new Service
             {
                 Id = 1,
                 ServiceName = "Test",
                 ServiceDescription = "Test",
                 ServiceCode = ""
             },
             new Service
             {
                 Id = 2,
                 ServiceName = "Test2",
                 ServiceDescription = "Test2",
                 ServiceCode=""
             }
            );
        }
    }
}
