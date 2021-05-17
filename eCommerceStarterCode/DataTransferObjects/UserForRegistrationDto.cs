using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Must provide input for IsSupplier field.")]
        public bool IsSupplier { get; set; }
        public string UserCurrency { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
