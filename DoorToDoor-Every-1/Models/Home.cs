using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoorToDoor_Every_1.Models
{
    public class Home
    {
        public int Id { get; set; }

        public bool DoorAnswered { get; set; }

        public bool Interested { get; set; }

        public string Notes { get; set; }

        public DateTime Visited { get; set; }

        public bool FollowUp { get; set; }
    }
}