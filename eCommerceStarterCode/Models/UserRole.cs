using eCommerceStarterCode.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class UserRole
    {

        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("AppRole")]
        public int RoleId { get; set; }
        public AppRole AppRole { get; set; }


        
    }
}
