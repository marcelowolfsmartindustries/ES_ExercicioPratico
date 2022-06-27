using ES_ExercicioPratico.Models;
using Microsoft.EntityFrameworkCore;

namespace ES_ExercicioPratico.Data
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Key> Keys { get; set; }
    }
}
