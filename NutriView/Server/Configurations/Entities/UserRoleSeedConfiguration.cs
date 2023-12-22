using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace NutriView.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "0afa81d9-cb31-4883-ae16-c9d0242e3440",
                UserId = "8aa738a7-6c07-4e5a-8a7f-5637388c41b4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "a1329842-8556-4ee7-ae1a-fd648064c54a",
                UserId = "41624b27-7496-447c-b299-4892483d6b47"
            },
            new IdentityUserRole<string>
            {
                RoleId = "428fdfc4-086b-4aba-bb98-148f31eaa143",
                UserId = "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521"
            },
            new IdentityUserRole<string>
            {
                RoleId = "f5a29727-ea9d-41d4-9175-dd1fb6ec2755",
                UserId = "4d3dfcba-a0af-4b10-989d-d63dcfec5e97"
            }
            );
        }
    }
}
