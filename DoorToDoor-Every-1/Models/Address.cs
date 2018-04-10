using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;

namespace DoorToDoor_Every_1.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Unit { get; set; }

        [Required]
        [RegularExpression(("[0-9]+"), ErrorMessage = "Please enter a valid number")]
        public int StreetNumber { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Postcode { get; set; }

        public bool DoorAnswered { get; set; }

        public bool Interested { get; set; }

        public string Notes { get; set; }

        public DateTime Visited { get; set; }

        public bool FollowUp { get; set; }


    }
}
