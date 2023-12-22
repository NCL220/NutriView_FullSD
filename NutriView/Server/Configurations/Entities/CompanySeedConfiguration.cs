using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
             new Company
             {
                 Id = 1,
                 Mission= "Our mission is to empower individuals to achieve optimal health through mindful eating. We understand that nutrition is not always a one-size-fits-all.Our goal is to guide you on a personalized journey towards a balanced and nourishing lifestyle that will bring you a step closer to a healthier you.",
                 CompanyDescription = "At NuriView Corporations, we believe that a heathy lifestyle would always begins with proper nutrition.We are a dedicated team of nutritionists and dietitians comitted in providing you with the knowledge and tools to aid you in your journey to a healthier diet.",
                 CompanyImagePath = "Not Yet Available",
                 CompanyName = "NutriView",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy="System",
                 UpdatedBy="System"
             },
             new Company
             {
                 Id = 2,
                 Mission = "Our Mission is to encourage people to eat healthy and live healthy",
                 CompanyDescription = "Not Yet Available",
                 CompanyImagePath = "Not Yet Available",
                 CompanyName = "NutriViewCorps",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );
        }
    }
}
