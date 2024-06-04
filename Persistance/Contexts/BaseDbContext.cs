using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts
{
    public class BaseDbContext: DbContext
    {

        public DbSet<TaxDepartment> TaxDepartments { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Product> Products { get; set; }


        public BaseDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        { 
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
