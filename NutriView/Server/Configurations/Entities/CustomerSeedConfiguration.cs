using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
             new Customer
             {
                 Id = 1,
                 UserName = "TestLim",
                 Age = 31,
                 Password = "Test222",
                 Email = "Test@Blazor.com",
                 Height = 160,
                 Weight = 88.5,
                 GenderID = 1,
                 DateCreated= DateTime.Now,
                 DateUpdated= DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"

             },
             new Customer
             {
                 Id = 2,
                 UserName = "TestRRLim",
                 Age = 32,
                 Password = "Test2212",
                 Email = "Test2@Blazor.com",
                 Height = 178,
                 Weight = 77,
                 GenderID = 2,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"

             }
            );
        }
    }
}