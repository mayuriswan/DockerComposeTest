using Microsoft.EntityFrameworkCore;
using testDockerCompose.Models;

namespace testDockerCompose.Data
{
   

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }

}
