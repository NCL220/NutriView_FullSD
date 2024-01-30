using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class GenderSeedConfiguration : IEntityTypeConfiguration<Gender>
    {
        
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
              new Gender
              {
                  Id = 1,
                  Name = "Male",
              },
              new Gender
              {
                  Id = 2,
                  Name = "Female",
              },
              new Gender
              {
                  Id = 3,
                  Name = "Others",
              }
              );
        }
    }
}
