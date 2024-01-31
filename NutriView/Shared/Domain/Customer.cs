
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

        public int GenderID { get; set; }

        public virtual Gender? Gender { get; set; }

        public byte[]? ImageBytes { get; set; }

        public virtual List<FoodEntry>? Entries { get; set; }

        
    }
}
