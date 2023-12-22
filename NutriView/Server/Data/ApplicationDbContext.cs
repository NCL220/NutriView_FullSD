using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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

    }
}