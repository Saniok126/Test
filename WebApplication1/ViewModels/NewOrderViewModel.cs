using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class NewOrderViewModel : IValidatableObject
    {
        public string Comment { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime, ErrorMessage = " Format not valid , use mm/dd/yyyy hh:mm")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateBegin { get; set; }
        [Required]
        public string ClientId { get; set; }

        public string PhoneNumber { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();
            if (Comment == null) errors.Add(new ValidationResult("Please enter comment!"));
            if (DateBegin == null) errors.Add(new ValidationResult("Date can`t be empty!"));
            if (PhoneNumber == null) errors.Add(new ValidationResult("Please enter your phone number!"));
            return errors;
        }
    }
}
