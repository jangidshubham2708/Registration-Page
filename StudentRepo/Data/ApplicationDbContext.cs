using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentRepo.Models.Entities;

namespace StudentRepo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet <Student> Students { get; set; }
    }
}