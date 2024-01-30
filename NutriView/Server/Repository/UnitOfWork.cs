using NutriView.Server.Data;
using NutriView.Server.IRepository;
using NutriView.Server.Models;
using NutriView.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NutriView.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<Company> _companies;
        private IGenericRepository<Food> _foods;
        private IGenericRepository<FoodEntry> _foodentries;
        private IGenericRepository<Meal> _meals;
        private IGenericRepository<NutritionalQuota> _nutritionalquotas;
        private IGenericRepository<NutritionInfo> _nutritioninfos;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Subscription> _subscriptions;
        private IGenericRepository<SubscriptionInfo> _subscriptioninfos;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Service> _services;
        private IGenericRepository<ServiceLinkSubInfo> _servicelinksubinfos;
        private IGenericRepository<Gender> _genders;
        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Service> Services
            => _services ??= new GenericRepository<Service>(_context);
        public IGenericRepository<Company> Companies
            => _companies ??= new GenericRepository<Company>(_context);
        public IGenericRepository<Food> Foods
            => _foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<FoodEntry> FoodEntries
            => _foodentries ??= new GenericRepository<FoodEntry>(_context);
        public IGenericRepository<Meal> Meals
            => _meals ??= new GenericRepository<Meal>(_context);
        public IGenericRepository<NutritionalQuota> NutritionalQuotas
            => _nutritionalquotas ??= new GenericRepository<NutritionalQuota>(_context);
        public IGenericRepository<NutritionInfo> NutritionInfos
            => _nutritioninfos ??= new GenericRepository<NutritionInfo>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Subscription> Subscriptions
            => _subscriptions ??= new GenericRepository<Subscription>(_context);
        public IGenericRepository<SubscriptionInfo> SubscriptionInfos
            => _subscriptioninfos ??= new GenericRepository<SubscriptionInfo>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Gender> Genders
            => _genders ??= new GenericRepository<Gender>(_context);

        public IGenericRepository<ServiceLinkSubInfo> ServiceLinkSubInfos
            => _servicelinksubinfos ??= new GenericRepository<ServiceLinkSubInfo>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}