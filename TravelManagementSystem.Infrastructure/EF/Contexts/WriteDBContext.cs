using Microsoft.EntityFrameworkCore;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Infrastructure.EF.Config;
using TravelManagementSystem.Infrastructure.EF.Models;

namespace TravelManagementSystem.Infrastructure.EF.Contexts
{
    internal sealed class WriteDBContext : DbContext
    {
        public DbSet<TravelerCheckList> TravelerCheckLists { get; set; }
        public WriteDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelerCheckList");
            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckList>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItem>(configuration);
        }
    }
}
