using Microsoft.EntityFrameworkCore;
using MVC_School.Models;

namespace MVC_School.Data
{
    public class SchoolDbContext : DbContext
    {

        public DbSet<Student> Studenten { get; set; }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
