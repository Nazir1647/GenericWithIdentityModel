using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Data.ViewModel
{
    public class RegistrationVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the firstName")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the lastName")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the email")]
        [EmailAddress]
        [StringLength(20, ErrorMessage = "StringLength must be 20 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the AddressLine1")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public DateTime DOB { get; set; }
        public string? Gender { get; set; }
        public string? CountryCode { get; set; }
        public string? Phone { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped] // its use when we not created this column during migration
        public string ConfirmPassword { get; set; }
    }
}
