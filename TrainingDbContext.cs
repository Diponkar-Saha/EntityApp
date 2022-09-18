using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EntityApp
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-8OIA8DB\\SQLEXPRESS;Database=CSharpS;User Id = sa; Password=1234;Encrypt=True;TrustServerCertificate=True; ";

            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<TTT> TTTT { get; set; }
        public DbSet<SSS> SSSS { get; set; }

        public DbSet<AllPublic> AllPublics { get; set; }



    }
}
