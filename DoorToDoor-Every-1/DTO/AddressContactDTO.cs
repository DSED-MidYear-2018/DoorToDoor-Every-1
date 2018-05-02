using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoorToDoor_Every_1.DTO
{
    public class AddressContactDTO
    {
        public int Id { get; set; }

        public string Unit { get; set; }

        public int StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Postcode { get; set; }

        public bool DoorAnswered { get; set; }

        public bool Interested { get; set; }

        public string Notes { get; set; }

        public DateTime Visited { get; set; }

        public bool FollowUp { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int AddressId { get; set; }
    }
}
