using System;

namespace NutriView.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";
        public static readonly string CompaniesEndpoint = $"{Prefix}/companies";
        public static readonly string FoodsEndpoint = $"{Prefix}/foods";
        public static readonly string FoodEntriesEndpoint = $"{Prefix}/foodentries";
        public static readonly string MealsEndpoint = $"{Prefix}/meals";
        public static readonly string NutritionalQuotasEndpoint = $"{Prefix}/nutritionalquotas";
        public static readonly string NutritionInfosEndpoint = $"{Prefix}/nutritioninfos";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string SubscriptionsEndpoint = $"{Prefix}/subscriptions";
        public static readonly string SubscriptionInfosEndpoint = $"{Prefix}/subscriptioninfos";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string EntryLinkFoodsEndpoint = $"{Prefix}/entrylinkfoods";
    }
}
