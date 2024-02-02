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
                 ServiceName = "SubmitFoodEntries",
                 ServiceDescription = "This Service will allow customer to Submit Food Entries",
                 ServiceCode = "9e7)9bD"
             },
             new Service
             {
                 Id = 2,
                 ServiceName = "Create Nutritional Quota",
                 ServiceDescription = "This Service will allow customer to create their Nutrtional Quota",
                 ServiceCode= "4I${wHZ"
             }
            );
        }
    }
}
