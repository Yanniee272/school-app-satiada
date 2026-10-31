using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;

namespace SchoolApp.Data
{
    public class SchoolAppContext : DbContext
    {
        public SchoolAppContext(DbContextOptions<SchoolAppContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
