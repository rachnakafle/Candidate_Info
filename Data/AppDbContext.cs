using Candidate_Info.Models;
using Microsoft.EntityFrameworkCore;

namespace Candidate_Info.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BasicInfo> Basic_Info { get; set; }
    }
}
