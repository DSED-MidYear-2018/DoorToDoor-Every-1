using System.Collections.Generic;
using System.Net.Mime;
using DoorToDoor_Every_1.Data;
using DoorToDoor_Every_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DoorToDoor_Every_1.Operations
{
    public class DatabaseManager
    {
        public static int AddressId { get; set; }
        public static string Address { get; set; }

        public static int ContactId { get; set; }
        public static string ContactDetails { get; set; }
        public static List<string> ContactDetailsList { get; set; }

        void GetContactDetails()
        {

        }
    }
}
