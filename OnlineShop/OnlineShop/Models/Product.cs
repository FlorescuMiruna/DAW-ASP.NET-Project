using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
    public class ProductDBContext :DbContext
    {
        public ProductDBContext() : base("DBConnectionString") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set;}

    }
}