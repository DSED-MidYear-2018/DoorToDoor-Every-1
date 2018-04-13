using System.Net.Mime;
using DoorToDoor_Every_1.Data;
using DoorToDoor_Every_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DoorToDoor_Every_1.Operations
{
    public class DatabaseManager
    {
        public static int AddressId { get; set; }
        public static string Address { get; set; }
    }
}
