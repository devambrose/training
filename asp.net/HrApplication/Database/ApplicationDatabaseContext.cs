using HrApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace HrApplication.Database
{
    public class ApplicationDatabaseContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }


        public DbSet<Dependant> Dependants { get; set; }


        public DbSet<Allowance> Allowances { get; set; }


        //configuration to connect to the database

       // define our table structures and the tables that we are going to access

        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options) { }

    }
}
