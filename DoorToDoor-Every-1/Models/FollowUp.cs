﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorToDoor_Every_1.Models
{
    public class FollowUp
    {
        public int Id { get; set; }
        public string DateReturn { get; set; }
        public string TimeReturn { get; set; }
        public string HomeId_F { get; set; }
        public Occurance OccurenceID_F { get; set; }
    }
}
