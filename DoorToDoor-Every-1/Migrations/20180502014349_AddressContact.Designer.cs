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
    [Migration("20180502014349_AddressContact")]
    partial class AddressContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("DoorToDoor_Every_1.DTO.AddressContactDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<bool>("DoorAnswered");

                    b.Property<string>("Email");

                    b.Property<bool>("FollowUp");

                    b.Property<bool>("Interested");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<string>("Phone");

                    b.Property<string>("Postcode");

                    b.Property<string>("StreetName");

                    b.Property<int>("StreetNumber");

                    b.Property<string>("Suburb");

                    b.Property<string>("Unit");

                    b.Property<DateTime>("Visited");

                    b.HasKey("Id");

                    b.ToTable("AddressContact");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<bool>("DoorAnswered");

                    b.Property<bool>("FollowUp");

                    b.Property<bool>("Interested");

                    b.Property<string>("Notes");

                    b.Property<string>("Postcode")
                        .IsRequired();

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.Property<int>("StreetNumber");

                    b.Property<string>("Suburb")
                        .IsRequired();

                    b.Property<string>("Unit");

                    b.Property<DateTime>("Visited");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminRoleId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("AdminRoleId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.AdminRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("AdminRole");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.FollowUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("DateReturn");

                    b.Property<int>("OccuranceId");

                    b.Property<string>("TimeReturn");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OccuranceId");

                    b.ToTable("FollowUps");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Occurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Occurances");
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.Admin", b =>
                {
                    b.HasOne("DoorToDoor_Every_1.Models.AdminRole", "AdminRoles")
                        .WithMany()
                        .HasForeignKey("AdminRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoorToDoor_Every_1.Models.FollowUp", b =>
                {
                    b.HasOne("DoorToDoor_Every_1.Models.Address", "Addresses")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorToDoor_Every_1.Models.Occurance", "Occurances")
                        .WithMany()
                        .HasForeignKey("OccuranceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
