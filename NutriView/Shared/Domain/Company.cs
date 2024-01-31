using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriView.Shared.Domain
{
    public class Company : BaseDomainModel, IValidatableObject
    {
        
        [StringLength(300, ErrorMessage = "Mission is too long.")]
        public string? Mission { get; set; }
        
        [StringLength(1000, ErrorMessage = "Description is too long.")]
        public string? CompanyDescription { get; set; }

        public byte[]? CompanyImageByte { get; set; }

        
        [StringLength(100, ErrorMessage = "Name is too long.")]
        public string? CompanyName { get; set; }

        public virtual List<Staff>? Staffs { get; set;}

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
