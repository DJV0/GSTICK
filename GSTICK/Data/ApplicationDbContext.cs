using GSTICK.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSTICK.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LiveOrder> LiveOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<GameCategory>().HasKey(gc => new { gc.GameId, gc.CategoryId });
            modelbuilder.Entity<GameCategory>()
                .HasOne(gc => gc.Game)
                .WithMany(gc => gc.Categories)
                .HasForeignKey(gc => gc.GameId);
            modelbuilder.Entity<GameCategory>()
                .HasOne(gc => gc.Category)
                .WithMany(gc => gc.Games)
                .HasForeignKey(gc => gc.CategoryId);
            base.OnModelCreating(modelbuilder);
        }
    }
}
