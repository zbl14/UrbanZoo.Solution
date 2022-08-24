using System.ComponentModel.DataAnnotations;
using System;

namespace UrbanZoo.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        // public DateTime ModifiedDate { set; } = null;
        public bool Availability { get; set; } = true;
        [Required]
        public string StreetAddress { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public string Zipcode { get; set; }
    }
}
