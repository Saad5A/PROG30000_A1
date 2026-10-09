using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PROG30000_A1.Models
{
    public class EquipmentRequest
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter a name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        
        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must follow xxx-xxx-xxxx format.")]


        public String PhoneNumber { get; set; }

        
        [Required(ErrorMessage = "Please select a user type")]
        public string UserType { get; set; }

        
        [Required(ErrorMessage = "Please select an equipment type")]
        [EnumDataType(typeof(EquipmentType), ErrorMessage = "Please select a valid equipment type")]
        public EquipmentType? EquipmentType { get; set; }


        [Required(ErrorMessage = "Please enter a duration in Days")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number (greater than zero).")]
        public int? Duration { get; set; }

        [Required (ErrorMessage = "Please enter request reason")]
        [StringLength(100, ErrorMessage = "Provide borrowing purpose ")]
        public String RequestDetails { get; set; } 








    }
}
