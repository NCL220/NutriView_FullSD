using NutriView.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriView.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<FoodEntry> FoodEntries { get; }
        IGenericRepository<Meal> Meals { get; }
        IGenericRepository<NutritionalQuota> NutritionalQuotas { get; }
        IGenericRepository<NutritionInfo> NutritionInfos { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Subscription> Subscriptions { get; }
        IGenericRepository<Subscription> SubscriptionInfos { get; }


        IGenericRepository<Customer> Customers { get; }
    }
}