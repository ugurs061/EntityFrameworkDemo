﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    // Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// veri tabanının belirtilmesi
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } // veritabanı nesnesini oluşturduğumuz ilgili classa bağlanılması
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
