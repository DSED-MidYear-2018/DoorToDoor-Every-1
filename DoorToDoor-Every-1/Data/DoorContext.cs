using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoorToDoor_Every_1.Models;
using Microsoft.EntityFrameworkCore;

namespace DoorToDoor_Every_1.Data
{
    public class DoorContext : DbContext
    {

        public DoorContext(DbContextOptions<DoorContext> options) : base(options)
        {
        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<Occurance> Occurances { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<FollowUp> FollowUps { get; set; }
        public DbSet<Admin> Admins { get; set; }


        //https://docs.microsoft.com/en-us/ef/core/modeling/keys

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //set the primary key of the tables
            modelBuilder.Entity<Home>()
                .HasKey(c => c.Id);
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

        public DbSet<DoorToDoor_Every_1.Models.AdminRole> AdminRole { get; set; }

        //https://docs.microsoft.com/en-us/ef/core/modeling/keys

        //https://docs.microsoft.com/en-us/ef/core/modeling/relationships


    }
}
