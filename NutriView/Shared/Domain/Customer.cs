using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NutriView.Shared.Domain
{
    public class Customer : BaseDomainModel, IValidatableObject
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(100, ErrorMessage = "Username must be less than 100 characters.")]
        public string UserName { get; set; }

        [Range(0, 150, ErrorMessage = "Age must be between 0 and 150.")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Range(0.0, double.MaxValue, ErrorMessage = "Height must be a positive number.")]
        public double? Height { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Weight must be a positive number.")]
        public double? Weight { get; set; }
        [Required(ErrorMessage = "Gender selection is required.")]
        public int GenderID { get; set; }

        public virtual Gender? Gender { get; set; }

        public byte[]? ImageBytes { get; set; }

        public virtual List<FoodEntry>? Entries { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

    }
}
