using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Basic_Games_Shelf.Models;

namespace Basic_Games_Shelf.Data
{
    public class BasicGamesShelfContext : DbContext
    {
        public BasicGamesShelfContext (DbContextOptions<BasicGamesShelfContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>()
            .Property(e => e.Platforms)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }

        public DbSet<Basic_Games_Shelf.Models.Games> Games { get; set; } = default!;
    }
}
