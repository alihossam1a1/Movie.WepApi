using Microsoft.EntityFrameworkCore;
using Moviee.ali.modes;
using System.Collections.Generic;

namespace Moviee.ali.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<modes.Movie> Movies { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Director> Directors { get; set; }

    }
}
