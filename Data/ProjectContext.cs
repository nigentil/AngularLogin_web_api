using AngularLogin_web_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin_web_api.Data
{
    public class ProjectContext:DbContext
    {
        //sempre no plural para saber que é uma lista
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=zs 2012!*;Persist Security Info=True;User ID=sa;Initial Catalog=Angular;Data Source=ITLNB063");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyUser>(Entity=> {
                Entity.HasKey(e => new { e.CompanyID, e.UserID });
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
