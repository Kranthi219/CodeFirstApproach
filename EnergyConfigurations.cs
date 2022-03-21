using CodeFirst.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace CodeFirst.Data
{

    public class StoreFeatureEnablementConfigurations : EntityTypeConfiguration<StoreFeatureEnablement>
    {
        public StoreFeatureEnablementConfigurations()
        {
            this.Property(s => s.StoreId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.StartDate).IsRequired()
                .HasColumnType("datetime2");

            this.Property(s => s.EndDate)
                .HasColumnType("datetime2");
        }

    }
}
