using Microsoft.EntityFrameworkCore;

namespace TASRDP
{
    using TASRDP.Models;

    public class AppDbContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
 
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Result> Results { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
