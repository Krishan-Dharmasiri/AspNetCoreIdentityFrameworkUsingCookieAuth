using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentityWithCookieAuthentication.Entities
{
    public class MovieDbContext : IdentityDbContext<User>
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
