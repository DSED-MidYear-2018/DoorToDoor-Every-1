using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoorToDoor_Every_1.Models
{
    public class FollowUp
    {
        public int Id { get; set; }
        public string DateReturn { get; set; }
        public string TimeReturn { get; set; }

        [Display(Name = "Occurence")]
        public int OccuranceId { get; set; }

        [ForeignKey("OccuranceId")]
        public virtual Occurance Occurances { get; set; }

        //Foreign Key
        [Display(Name = "Address")]
        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Addresses { get; set; }
    }
}