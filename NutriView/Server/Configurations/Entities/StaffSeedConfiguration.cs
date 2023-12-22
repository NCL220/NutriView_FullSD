using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
             new Staff
             {
                 Id = 1,
                 CompanyId = 1,
                 ManagerID = 1,
                 UserName = "ChunLim",
                 Role = "Manager",
                 Password = "Chun11",
                 Email = "ngchunlim04@gmail.com",
                 PhoneNumber = 87993192,
                 ImagePathStaff = "-",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new Staff
             {
                 Id = 2,
                 CompanyId = 1,
                 ManagerID = 2,
                 UserName = "Kenneth",
                 Role = "Manager",
                 Password = "Lim12",
                 Email = "Test04@gmail.com",
                 PhoneNumber = 87993192,
                 ImagePathStaff = "-",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );

        }
    }
    }
