using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserCurrency { get; set; }
        public bool IsSupplier { get; set; }
    }
}
