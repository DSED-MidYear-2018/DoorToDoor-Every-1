using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Humanizer.DateTimeHumanizeStrategy;

namespace DoorToDoor_Every_1.Models
{
    public class FollowUp
    {
        public int Id { get; set; }

        public DateTime DateReturn { get; set; } //= DateReturn.Humanize();
        public string TimeReturn { get; set; }
        public int OccuranceId { get; set; }
        public int AddressId { get; set; }

        public void ShortDate()
        {
            //DateReturn = Convert.ToDateTime(DateReturn.Humanize());
        }
    }
}