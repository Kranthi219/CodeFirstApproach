using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst.Data.Entities
{
    public class FeatureLookUp
    {
        [Key]
        public int Id { get; set; }
        public string? FeatureName { get; set; }

    }
}
