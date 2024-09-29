using Microsoft.EntityFrameworkCore;
using TravelManagementSystem.Infrastructure.EF.Config;
using TravelManagementSystem.Infrastructure.EF.Models;

namespace TravelManagementSystem.Infrastructure.EF.Contexts
{
    internal sealed class ReadDBContext : DbContext
    {
        public DbSet<TravelerCheckListReadModel> travelerCheckList { get; set; }

        public ReadDBContext(DbContextOptions<ReadDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelerCheckList");
            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckListReadModel>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItemReadModel>(configuration);
        }

    }

}
