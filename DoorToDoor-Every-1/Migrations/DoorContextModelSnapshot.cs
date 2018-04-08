﻿// <auto-generated />
using DoorToDoor_Every_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DoorToDoor_Every_1.Migrations
{
    [DbContext(typeof(DoorContext))]
    partial class DoorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Postcode");

                    b.Property<int>("StreetNumber");

                    b.Property<string>("Suburb");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.AdminRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AdminId");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("AdminRole");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.FollowUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateReturn");

                    b.Property<string>("TimeReturn");

                    b.HasKey("Id");

                    b.ToTable("FollowUps");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContactId");

                    b.Property<bool>("DoorAnswered");

                    b.Property<bool>("FollowUp");

                    b.Property<int?>("FollowUpId");

                    b.Property<bool>("Interested");

                    b.Property<string>("Notes");

                    b.Property<DateTime>("Visited");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("FollowUpId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Occurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FollowUpId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("FollowUpId");

                    b.ToTable("Occurances");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.AdminRole", b =>
                {
                    b.HasOne("DoorToDoor_Every_1.Models.Admin")
                        .WithMany("AdminRoles")
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Home", b =>
                {
                    b.HasOne("DoorToDoor_Every_1.Models.Contact")
                        .WithMany("Homes")
                        .HasForeignKey("ContactId");

                    b.HasOne("DoorToDoor_Every_1.Models.FollowUp")
                        .WithMany("Homes")
                        .HasForeignKey("FollowUpId");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Occurance", b =>
                {
                    b.HasOne("DoorToDoor_Every_1.Models.FollowUp")
                        .WithMany("Occurances")
                        .HasForeignKey("FollowUpId");
                });
#pragma warning restore 612, 618
        }
    }
}
