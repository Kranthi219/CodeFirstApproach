using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst.Data.Entities
{
    public class StoreFeatureEnablement
    {
        [Key]
        public int Id { get; set; }
        public string StoreId { get; set; }
        public int FeatureId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [ForeignKey("FeatureId")]
        public virtual FeatureLookUp FeatureLookUp { get; set; }
    }
}
