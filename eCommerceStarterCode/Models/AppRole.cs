using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class AppRole
    {
        [Key]
        
        public int RoleId { get; set; }
        public string RoleName { get; set; }

    }
}
