using System;
using System.Data.Entity;
using CodeFirst.Data.Entities;

namespace CodeFirst.Data
{
    public class EnergyContext : DbContext
    {
        public EnergyContext() : base(@"Data Source=DESKTOP-AH9EOVA\SQLEXPRESS;Initial Catalog=Energy;Integrated Security=true")
        {
            Database.SetInitializer<EnergyContext>(new EnergyDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeatureLookUp>().Property(s => s.FeatureName).IsRequired()
                .HasMaxLength(50);


            modelBuilder.Configurations.Add(new StoreFeatureEnablementConfigurations());
        }

        public DbSet<FeatureLookUp> FeatureLookUps { get; set; }

        public DbSet<StoreFeatureEnablement> StoreFeatureEnablements { get; set; }      

    }
}
