using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(100, ErrorMessage = "Username must be less than 100 characters.")]
        public string UserName { get; set; }
        [StringLength(100, ErrorMessage = "Role must be less than 100 characters.")]
        public string? Role { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required] 
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string? PhoneNumber { get; set; }

        public byte[]? ImageByte { get; set; }
        public virtual List<NutritionInfo>? NutritionInfos { get; set; }
        public virtual List<Food>? Foods { get; set; }

        public int? ManagerID { get; set; }

        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyId {  get; set; }
        public virtual Company? Company { get; set; }
    }
}
