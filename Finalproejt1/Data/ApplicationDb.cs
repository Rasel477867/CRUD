using Finalproejt1.Models;
using Microsoft.EntityFrameworkCore;

namespace Finalproejt1.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
