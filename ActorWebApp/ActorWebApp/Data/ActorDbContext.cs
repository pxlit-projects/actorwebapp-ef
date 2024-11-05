using ActorWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ActorWebApp.Data
{
    public class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options) { }
    }
}
