using Microsoft.EntityFrameworkCore;

namespace RecruitmentSystem.Persistence
{
    public class RecruitmentDbContext : DbContext
    {
        public RecruitmentDbContext(DbContextOptions<RecruitmentDbContext> options)
            : base(options) { }
    }
}