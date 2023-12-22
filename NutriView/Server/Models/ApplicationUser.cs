using Microsoft.AspNetCore.Identity;
using NutriView.Shared.Domain;

namespace NutriView.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}