using Melvin.EF.Entites;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Melvin.Entities
{
    public class TaxContext : DbContext
    {
        public DbSet<TaxProgression> taxProgression { get; set; }
        public DbSet<TaxProgressionHistory> taxProgressionHistory { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                          .AddJsonFile("appsettings.json")
                          .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("dbConnectionString"));
            }
        }
    }
}
