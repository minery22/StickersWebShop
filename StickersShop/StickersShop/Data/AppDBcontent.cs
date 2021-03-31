using Microsoft.EntityFrameworkCore;
using StickersShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickersShop.Data
{
    public class AppDBcontent : DbContext 
    {
        public AppDBcontent(DbContextOptions<AppDBcontent> options) : base(options)
        {

        }
        public DbSet<Sticker> Sticker { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopIt> ShopIt { get; set; }
    }
}
