using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DoorToDoor_Every_1.Models
{
    public class Contact
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        //Foreign Key
        [Display(Name = "Address")]
        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Addresses { get; set; }
    }
}