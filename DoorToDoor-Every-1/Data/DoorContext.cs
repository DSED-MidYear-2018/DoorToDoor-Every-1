using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoorToDoor_Every_1.DTO;
using DoorToDoor_Every_1.Models;
using Microsoft.EntityFrameworkCore;

namespace DoorToDoor_Every_1.Data
{
    public class DoorContext : DbContext
    {

        public DoorContext(DbContextOptions<DoorContext> options) : base(options)
        {
        }

        public DbSet<Occurance> Occurances { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<FollowUp> FollowUps { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminRole> AdminRole { get; set; }
        public DbSet<AddressContactDTO> AddressContact { get; set; }


        //https://docs.microsoft.com/en-us/ef/core/modeling/keys

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Occurance>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Contact>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Address>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<FollowUp>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Admin>()
                .HasKey(c => c.Id);
        }

        //https://docs.microsoft.com/en-us/ef/core/modeling/keys

        //https://docs.microsoft.com/en-us/ef/core/modeling/keys

        //https://docs.microsoft.com/en-us/ef/core/modeling/relationships

    }
}
