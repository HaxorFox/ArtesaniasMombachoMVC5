using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ArtMombacho.Models;

namespace ArtMombacho.DAL
{
    public class ArtMombachoContext : DbContext

    {
        public ArtMombachoContext() : base("ArtMombachoDB")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<File> Files { get; set; }

    }
}