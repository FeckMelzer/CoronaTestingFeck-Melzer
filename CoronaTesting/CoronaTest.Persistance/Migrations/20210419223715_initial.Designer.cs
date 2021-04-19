﻿// <auto-generated />
using System;
using CoronaTest.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoronaTest.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210419223715_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("CampaignTestCenter", b =>
                {
                    b.Property<int>("AvailableCampaignsId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableTestCentersId")
                        .HasColumnType("int");

                    b.HasKey("AvailableCampaignsId", "AvailableTestCentersId");

                    b.HasIndex("AvailableTestCentersId");

                    b.ToTable("CampaignTestCenter");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.AuthToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid>("Identifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsInvalidated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Token")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.ToTable("VerificationTokens");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.Examination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExaminationAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExaminationState")
                        .HasColumnType("int");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("TestCenterId")
                        .HasColumnType("int");

                    b.Property<int>("TestResult")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("TestCenterId");

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Door")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobilphone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Verification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.TestCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("SlotCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestCenters");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@htl.at",
                            Password = "z81/WXFsEMzwVRDDYwpJCcGO/FHhG/bW10RVqrO7Bnc=f7af3fec481c316a314d7cff76e9205d",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@htl.at",
                            Password = "YxHbWA40YMt07hE/53OsOoGzLdt2/YayyOeurl/BcaM=c5ea9c8836c0032ebe6bbc0a168bf31e",
                            Role = "User"
                        });
                });

            modelBuilder.Entity("CampaignTestCenter", b =>
                {
                    b.HasOne("CoronaTest.Core.Entities.Campaign", null)
                        .WithMany()
                        .HasForeignKey("AvailableCampaignsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoronaTest.Core.Entities.TestCenter", null)
                        .WithMany()
                        .HasForeignKey("AvailableTestCentersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.AuthToken", b =>
                {
                    b.HasOne("CoronaTest.Core.Entities.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("CoronaTest.Core.Entities.Examination", b =>
                {
                    b.HasOne("CoronaTest.Core.Entities.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId");

                    b.HasOne("CoronaTest.Core.Entities.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId");

                    b.HasOne("CoronaTest.Core.Entities.TestCenter", "TestCenter")
                        .WithMany()
                        .HasForeignKey("TestCenterId");

                    b.Navigation("Campaign");

                    b.Navigation("Participant");

                    b.Navigation("TestCenter");
                });
#pragma warning restore 612, 618
        }
    }
}
