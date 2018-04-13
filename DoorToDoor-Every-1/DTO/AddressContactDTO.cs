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

        public static string Unit { get; set; }

        public static int StreetNumber { get; set; }

        public static string StreetName { get; set; }

        public static string Suburb { get; set; }

        public static string City { get; set; }

        public static string Country { get; set; }

        public static string Postcode { get; set; }

        public static bool DoorAnswered { get; set; }

        public static bool Interested { get; set; }

        public static string Notes { get; set; }

        public static DateTime Visited { get; set; }

        public static bool FollowUp { get; set; }

        public static string Name { get; set; }

        public static string Phone { get; set; }

        public static string Email { get; set; }

        public static int AddressId { get; set; }
    }
}
