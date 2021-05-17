using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode
{
    public class UserRoleClass
    {
        private ApplicationDbContext _context;

        public UserRoleClass()
        {
            _context = new ApplicationDbContext();

        }

        public void AddRoleId(string userId)
        {
            bool isSupplier = _context.Users.Where(u => u.Id == userId).Select(u => u.IsSupplier).SingleOrDefault();
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                Console.WriteLine("User Not Found");
            }
            else if (!isSupplier)
            {
                UserRole newUserRole = new UserRole()
                {
                    UserId = _context.Users.Where(u => u.Id == userId).Select(u => u.Id).SingleOrDefault(),
                    RoleId = 1
                };
                _context.UserRoles.Add(newUserRole);
                _context.SaveChanges();

            }
            else if (isSupplier)
            {
                UserRole newUserRole = new UserRole()
                {
                    UserId = _context.Users.Where(u => u.Id == userId).Select(u => u.Id).SingleOrDefault(),
                    RoleId = 2
                };
                _context.UserRoles.Add(newUserRole);
                _context.SaveChanges();

            }

        }
    }
}
