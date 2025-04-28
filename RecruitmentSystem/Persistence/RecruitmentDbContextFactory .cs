using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RecruitmentSystem.Persistence
{
    public class RecruitmentDbContextFactory : IDesignTimeDbContextFactory<RecruitmentDbContext>
    {
        public RecruitmentDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<RecruitmentDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new RecruitmentDbContext(optionsBuilder.Options);
        }
    }
}
