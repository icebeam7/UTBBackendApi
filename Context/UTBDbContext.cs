using Microsoft.EntityFrameworkCore;
using UTBBackendApi.Models;

namespace UTBBackendApi.Context
{
    public class UTBDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public UTBDbContext(
            DbContextOptions<UTBDbContext> options) 
            : base(options)
        {

        }
    }
}
