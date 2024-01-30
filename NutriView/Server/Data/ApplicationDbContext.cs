using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NutriView.Server.Configurations.Entities;
using NutriView.Server.Models;
using NutriView.Shared.Domain;

namespace NutriView.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<NutritionInfo> NutritionInfos { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodEntry> FoodEntries { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<NutritionalQuota> NutritionalQuotas { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<SubscriptionInfo> SubscriptionInfos { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<EntryLinkFood> EntryLinkFoods { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ServiceLinkSubInfo> ServiceLinkSubInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ServiceSeedConfiguration());
            builder.ApplyConfiguration(new EntryLinkFoodSeedConfiguration());
            builder.ApplyConfiguration(new SubscriptionInfoSeedConfiguration());
            builder.ApplyConfiguration(new CompanySeedConfiguration());
            builder.ApplyConfiguration(new NutritionInfoSeedConfiguration());
            builder.ApplyConfiguration(new FoodSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new SubscriptionSeedConfiguration());
            builder.ApplyConfiguration(new FoodEntrySeedConfiguration());
            builder.ApplyConfiguration(new MealSeedConfiguration());
            builder.ApplyConfiguration(new NutritionalQuotaSeedConfiguration());
            builder.ApplyConfiguration(new ServiceLinkSubInfoSeedConfiguration());
            builder.ApplyConfiguration(new GenderSeedConfiguration());

        }


    }
}