using Microsoft.EntityFrameworkCore;
using runo.Models.Entities;

namespace runo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
