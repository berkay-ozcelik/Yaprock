using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Yaprock.Core.Entity;

namespace Yaprock.Repository.DbContext
{
    public class YaprockDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public YaprockDbContext(DbContextOptions<YaprockDbContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
