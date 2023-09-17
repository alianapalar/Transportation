﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transportation.DataAccessLayer.Context;

#nullable disable

namespace Transportation.UI.Migrations
{
    [DbContext(typeof(TransportationContext))]
    [Migration("20230917154903_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "a3894fdd-18da-4e45-a5a4-2d47be160eb7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "0fd619ce-11a3-4ec4-b6ab-24eeaab4b8c5",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            DriverId = 1,
                            Description = "46 yaşında",
                            DriverName = "Şükrü Şükran",
                            Image = "~/logistica-1.0.0/img/team-1.jpg"
                        },
                        new
                        {
                            DriverId = 2,
                            Description = "36 yaşında",
                            DriverName = "Sezai Sezdi",
                            Image = "~/logistica-1.0.0/img/team-2.jpg"
                        },
                        new
                        {
                            DriverId = 3,
                            Description = "32 yaşında",
                            DriverName = "Devir Daim",
                            Image = "~/logistica-1.0.0/img/team-3.jpg"
                        },
                        new
                        {
                            DriverId = 4,
                            Description = "49 yaşında",
                            DriverName = "Engin Ermiş",
                            Image = "~/logistica-1.0.0/img/team-4.jpg"
                        },
                        new
                        {
                            DriverId = 5,
                            Description = "60 yaşında",
                            DriverName = "Fedai Feda",
                            Image = "~/logistica-1.0.0/img/team-1.jpg"
                        });
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReceiverUserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SenderUserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.RequestType", b =>
                {
                    b.Property<int>("RequestTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestTypeId"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestTypeId");

                    b.ToTable("RequestTypes");

                    b.HasData(
                        new
                        {
                            RequestTypeId = 1,
                            Image = "/logistica-1.0.0/img/evdentasima.jpg",
                            RequestName = "Evden Taşıma"
                        },
                        new
                        {
                            RequestTypeId = 2,
                            Image = "/logistica-1.0.0/img/agirlikta-esya-tasima.jpg",
                            RequestName = "Ağırlıkta Eşya Taşıma"
                        },
                        new
                        {
                            RequestTypeId = 3,
                            Image = "/logistica-1.0.0/img/ofis-tasima.jpg",
                            RequestName = "Ofis Taşıma"
                        },
                        new
                        {
                            RequestTypeId = 4,
                            Image = "/logistica-1.0.0/img/buyuk-hacim.jpeg",
                            RequestName = "Büyük Hacim"
                        });
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("TransportRequestId")
                        .HasColumnType("int");

                    b.Property<int>("TransportTeamId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("DriverId");

                    b.HasIndex("TransportRequestId")
                        .IsUnique();

                    b.HasIndex("TransportTeamId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamMemberId"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransportTeamId")
                        .HasColumnType("int");

                    b.HasKey("TeamMemberId");

                    b.HasIndex("TransportTeamId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            TeamMemberId = 1,
                            Image = "~/logistica-1.0.0/img/team-1.jpg",
                            Name = "Aslı Aslan",
                            Position = "Expert",
                            TransportTeamId = 1
                        },
                        new
                        {
                            TeamMemberId = 2,
                            Image = "~/logistica-1.0.0/img/team-2.jpg",
                            Name = "Sezai Sezgin",
                            Position = "Expert",
                            TransportTeamId = 1
                        },
                        new
                        {
                            TeamMemberId = 3,
                            Image = "~/logistica-1.0.0/img/team-3.jpg",
                            Name = "Ayhan Keser",
                            Position = "Expert",
                            TransportTeamId = 1
                        },
                        new
                        {
                            TeamMemberId = 4,
                            Image = "~/logistica-1.0.0/img/team-4.jpg",
                            Name = "Ferdi Geldi",
                            Position = "Expert",
                            TransportTeamId = 1
                        });
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TransportRequest", b =>
                {
                    b.Property<int>("TransportRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransportRequestId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TransportRequestId");

                    b.HasIndex("RequestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("TransportRequests");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TransportTeam", b =>
                {
                    b.Property<int>("TransportTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransportTeamId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransportTeamId");

                    b.ToTable("TransportTeams");

                    b.HasData(
                        new
                        {
                            TransportTeamId = 1,
                            Description = "Deneyimli taşımacılar",
                            TeamName = "X Taşıma Ekibi"
                        });
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"), 1L, 1);

                    b.Property<int?>("DriverId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.HasIndex("DriverId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            VehicleId = 1,
                            DriverId = 1,
                            Image = "~/logistica-1.0.0/img/service-3.jpg",
                            VehicleInfo = "Chrysler",
                            VehicleType = "Tır"
                        },
                        new
                        {
                            VehicleId = 2,
                            DriverId = 2,
                            Image = "~/logistica-1.0.0/img/service-6.jpg",
                            VehicleInfo = "Mercedes Benz",
                            VehicleType = "Kamyon"
                        },
                        new
                        {
                            VehicleId = 3,
                            DriverId = 3,
                            Image = "~/logistica-1.0.0/img/service-1.jpg",
                            VehicleInfo = "DAF",
                            VehicleType = "Tır"
                        },
                        new
                        {
                            VehicleId = 4,
                            DriverId = 4,
                            Image = "~/logistica-1.0.0/img/service-2.jpg",
                            VehicleInfo = "Scania",
                            VehicleType = "Kamyon"
                        },
                        new
                        {
                            VehicleId = 5,
                            DriverId = 5,
                            Image = "~/logistica-1.0.0/img/service-4.jpg",
                            VehicleInfo = "BMC",
                            VehicleType = "Kamyonet"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Message", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", "ReceiverUser")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverUserId")
                        .IsRequired();

                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", "SenderUser")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderUserId")
                        .IsRequired();

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Reservation", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transportation.EntityLayer.Entities.TransportRequest", "TransportRequest")
                        .WithOne("Reservation")
                        .HasForeignKey("Transportation.EntityLayer.Entities.Reservation", "TransportRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transportation.EntityLayer.Entities.TransportTeam", "TransportTeam")
                        .WithMany()
                        .HasForeignKey("TransportTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transportation.EntityLayer.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("TransportRequest");

                    b.Navigation("TransportTeam");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Review", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId");

                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", "User")
                        .WithMany("GivenReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TeamMember", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.TransportTeam", "TransportTeam")
                        .WithMany("TeamMembers")
                        .HasForeignKey("TransportTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransportTeam");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TransportRequest", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.RequestType", "Request")
                        .WithMany()
                        .HasForeignKey("RequestTypeId");

                    b.HasOne("Transportation.EntityLayer.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.Vehicle", b =>
                {
                    b.HasOne("Transportation.EntityLayer.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.AppUser", b =>
                {
                    b.Navigation("GivenReviews");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TransportRequest", b =>
                {
                    b.Navigation("Reservation")
                        .IsRequired();
                });

            modelBuilder.Entity("Transportation.EntityLayer.Entities.TransportTeam", b =>
                {
                    b.Navigation("TeamMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
