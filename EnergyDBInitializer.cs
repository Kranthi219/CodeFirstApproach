using CodeFirst.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirst.Data
{
    public class EnergyDBInitializer : DropCreateDatabaseIfModelChanges<EnergyContext>
    {
        protected override void Seed(EnergyContext context)
        {
            IList<FeatureLookUp> featureLookUps = new List<FeatureLookUp>();

            featureLookUps.Add(new FeatureLookUp() { FeatureName = "unitclocksync" });
            featureLookUps.Add(new FeatureLookUp() { FeatureName = "astroclock" });
            featureLookUps.Add(new FeatureLookUp() { FeatureName = "HvacDemandshedding" });

            context.FeatureLookUps.AddRange(featureLookUps);

            base.Seed(context);
        }
    }
}
