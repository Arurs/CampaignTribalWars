using Microsoft.EntityFrameworkCore;

namespace CampaignApi.Enities
{
    public class CampaignContext :DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Command> Commands { get; set; }
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=CampaignDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
