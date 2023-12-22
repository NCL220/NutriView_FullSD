using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace NutriView.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "0afa81d9-cb31-4883-ae16-c9d0242e3440",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "a1329842-8556-4ee7-ae1a-fd648064c54a",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            },
            new IdentityRole
            {
                Id = "428fdfc4-086b-4aba-bb98-148f31eaa143",
                Name = "Staff",
                NormalizedName = "STAFF"
            }, 
            new IdentityRole
            {
                Id = "f5a29727-ea9d-41d4-9175-dd1fb6ec2755",
                Name = "Manager",
                NormalizedName = "MANAGER"
            }
            );
        }
    }
}
