using NutriView.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NutriView.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            },
            new ApplicationUser
            {
                Id = "41624b27-7496-447c-b299-4892483d6b47",
                Email = "Customer@localhost.com",
                NormalizedEmail = "Customer@LOCALHOST.COM",
                FirstName = "Customer",
                LastName = "User",
                UserName = "Customer@localhost.com",
                NormalizedUserName = "CUSTOMER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            },
            new ApplicationUser
            {
                Id = "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                Email = "Manager@localhost.com",
                NormalizedEmail = "Manager@LOCALHOST.COM",
                FirstName = "Manager",
                LastName = "User",
                UserName = "Manager@localhost.com",
                NormalizedUserName = "MANAGER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            },
            new ApplicationUser
            {
                Id = "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                Email = "Staff@localhost.com",
                NormalizedEmail = "Staff@LOCALHOST.COM",
                FirstName = "Staff",
                LastName = "User",
                UserName = "Staff@localhost.com",
                NormalizedUserName = "STAFF@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
        }
    }
}
