using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;

namespace WebAPIDemo.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Learner> Learners { get; set; }
    }
}
