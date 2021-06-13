using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Data
{
    public class Cargo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string DeliveryCity { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
    }
}
