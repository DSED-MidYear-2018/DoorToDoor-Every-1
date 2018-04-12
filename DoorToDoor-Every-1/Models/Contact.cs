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
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //Foreign Key
        [Display(Name = "Address")]
        public static int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Addresses { get; set; }
    }
}