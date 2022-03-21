using CodeFirst.Data;
using CodeFirst.Data.Entities;
using System;

namespace CodeFirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EnergyContext())
            {
                var storeFeatureEnablement = new StoreFeatureEnablement()
                {
                    StoreId = "US-10",
                    StartDate = DateTime.UtcNow,
                    FeatureId = 1
                };

                ctx.StoreFeatureEnablements.Add(storeFeatureEnablement);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}
