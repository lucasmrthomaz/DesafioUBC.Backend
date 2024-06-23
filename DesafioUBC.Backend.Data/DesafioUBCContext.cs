using DesafioUBC.Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioUBC.Backend.Data
{
    public class DesafioUBCContext : DbContext
    {
        public DesafioUBCContext() { }

        public DesafioUBCContext(DbContextOptions<DesafioUBCContext> options)
          : base(options)
        { }

        public DbSet<Student> Student { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DesafioUBC;ConnectRetryCount=0");
        }
    }
}
