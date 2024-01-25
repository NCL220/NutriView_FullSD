using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriView.Shared.Domain;

namespace NutriView.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
             builder.HasData(
             new Food
             {
                 Id=1,
                 StaffId=1,
                 Name="Carrots",
                 Calories = 25,
                 Carbohydrates = 6,
                 Fats = 0.1,
                 Vitamins = "A,C,K",
                 ServingSize=61,
                 FoodDesc="Carrots Contains 25 Calories and 6g of Carbohydrates , etc",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
             new Food
             {
                 Id=2,
                 StaffId=2,
                 Name = "Chicken",
                 Calories = 165,
                 Carbohydrates = 0,
                 Fats = 3.6,
                 Vitamins = "A, B6, C, D, E",
                 ServingSize = 100,
                 FoodDesc = "Chicken Contains 165 Calories per 100 grams and does not have any Carbohydrates , etc",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
            );

        }
    }
}
