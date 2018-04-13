using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoorToDoor_Every_1.DTO
{
    public class ContactIdDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int AddressId { get; set; }
    }
}
