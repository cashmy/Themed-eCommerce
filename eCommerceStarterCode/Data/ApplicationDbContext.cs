using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public virtual DbSet<AppRole> AppRoles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public object CategoryClass { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=eCommerce;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.Entity<User>();
            modelBuilder.Entity<UserRole>();
            modelBuilder.Entity<AppRole>()
                .HasData(
                    new AppRole { RoleId = 1, RoleName= "Customer" },
                    new AppRole { RoleId = 2, RoleName= "Employee" },
                    new AppRole { RoleId = 3, RoleName= "Admin" }

                ); 
        }

    }
}
