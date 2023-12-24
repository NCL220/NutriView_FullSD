
namespace NutriView.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? UserName { get; set; }

        public int? Age { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public double? Height { get; set; }

        public double? Weight { get; set; }

        public string? Gender { get; set; }

        public virtual List<FoodEntry>? Entries { get; set; }

    }
}
