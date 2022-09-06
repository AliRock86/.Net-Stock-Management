using Stock_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Stock_Management.Data
{
    public partial class StockDbContext : DbContext
    {
        public StockDbContext()
        {
        }

        public StockDbContext(DbContextOptions<StockDbContext> options)
        : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<PermissionUser> PermissionUsers { get; set; }
        public DbSet<StockUser> StockUsers { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = @"Data Source=ALI-IT\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}


