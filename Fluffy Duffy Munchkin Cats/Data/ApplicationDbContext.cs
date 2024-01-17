using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fluffy_Duffy_Munchkin_Cats.Models;

namespace Fluffy_Duffy_Munchkin_Cats.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fluffy_Duffy_Munchkin_Cats.Models.Cats> Cats { get; set; } = default!;
    }
}
