using Cotizacion.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Cotizacion.DAL
{
    public class CotizacionDbContext : DbContext
    {
        public CotizacionDbContext(DbContextOptions<CotizacionDbContext> options) : base(options)
        {
        }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            IList<Client> clients = new List<Client>() {
                new Client { Id = 1, Name = "Camilo" },
                new Client { Id = 2, Name = "Alexandra" },
                new Client { Id = 3, Name = "Santiago" }
            };

            foreach (Client client in clients)
            {
                builder.Entity<Client>().HasData(client);
            }
            
            IList<Seller> sellers = new List<Seller>() {
                new Seller { Id = 1, Name = "Camilo" },
                new Seller { Id = 2, Name = "Alexandra" },
                new Seller { Id = 3, Name = "Santiago" }
            };

            foreach (Seller seller in sellers)
            {
                builder.Entity<Seller>().HasData(seller);
            }
           
            IList<Product> products = new List<Product>() {
                new Product { Id = 1, Name = "Arandanos" },
                new Product { Id = 2, Name = "Arroz" },
                new Product { Id = 3, Name = "Café" }
            };

            foreach (Product product in products)
            {
                builder.Entity<Client>().HasData(product);
            }
        }
    }
}
