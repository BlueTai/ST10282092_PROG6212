using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore;
using ST10282092_PROG6212_POE.Models;

namespace ST10282092_PROG6212_POE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        // Example DbSets
        public DbSet<Claim> Claims { get; set; }
       
        public DbSet<ILecturer> Lecturers { get; set; }
    }

    public interface ILecturer
    {
    }
}