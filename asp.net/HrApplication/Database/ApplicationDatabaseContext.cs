using HrApplication.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HrApplication.Database
{
   // public class ApplicationDatabaseContext : DbContext
        public class ApplicationDatabaseContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<Employee> Employees { get; set; }


        public DbSet<Dependant> Dependants { get; set; }


        public DbSet<Allowance> Allowances { get; set; }

        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options) { }

    }
}
