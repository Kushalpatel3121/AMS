﻿// <auto-generated />
using System;
using AMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220521083957_second init")]
    partial class secondinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("AMS.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AMS.Models.Mandal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Day")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int?>("KaryakarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KshetraId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("NirikshakId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KaryakarId");

                    b.HasIndex("KshetraId");

                    b.ToTable("Mandal");
                });

            modelBuilder.Entity("AMS.Models.Sabha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("MandalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MandalId");

                    b.ToTable("Sabha");
                });

            modelBuilder.Entity("AMS.Models.SabhaAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("SabhaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YuvakId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SabhaId");

                    b.HasIndex("YuvakId");

                    b.ToTable("SabhaAttendance");
                });

            modelBuilder.Entity("AMS.Models.SamparkKaryakar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KaryakarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SanchalakId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YuvakCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KaryakarId");

                    b.HasIndex("SanchalakId");

                    b.ToTable("SamparkKaryakar");
                });

            modelBuilder.Entity("AMS.Models.Sanchalak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KaryakarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MandalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KaryakarId");

                    b.HasIndex("MandalId");

                    b.ToTable("Sanchalak");
                });

            modelBuilder.Entity("AMS.Models.Yuvak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("MandalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("SamparkId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SamparkKaryakarId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MandalId");

                    b.HasIndex("SamparkKaryakarId");

                    b.ToTable("Yuvak");
                });

            modelBuilder.Entity("AMS.web.Models.Karyakar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobileNo")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Karyakar");
                });

            modelBuilder.Entity("AMS.web.Models.Kshetra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KaryakarId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("NirdeshakId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KaryakarId");

                    b.ToTable("Kshetra");
                });

            modelBuilder.Entity("AMS.web.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Use")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AMS.Models.Mandal", b =>
                {
                    b.HasOne("AMS.web.Models.Karyakar", "Karyakar")
                        .WithMany()
                        .HasForeignKey("KaryakarId");

                    b.HasOne("AMS.web.Models.Kshetra", "Kshetra")
                        .WithMany()
                        .HasForeignKey("KshetraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Karyakar");

                    b.Navigation("Kshetra");
                });

            modelBuilder.Entity("AMS.Models.Sabha", b =>
                {
                    b.HasOne("AMS.Models.Mandal", "Mandal")
                        .WithMany()
                        .HasForeignKey("MandalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mandal");
                });

            modelBuilder.Entity("AMS.Models.SabhaAttendance", b =>
                {
                    b.HasOne("AMS.Models.Sabha", "Sabha")
                        .WithMany()
                        .HasForeignKey("SabhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMS.Models.Yuvak", "Yuvak")
                        .WithMany()
                        .HasForeignKey("YuvakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sabha");

                    b.Navigation("Yuvak");
                });

            modelBuilder.Entity("AMS.Models.SamparkKaryakar", b =>
                {
                    b.HasOne("AMS.web.Models.Karyakar", "Karyakar")
                        .WithMany()
                        .HasForeignKey("KaryakarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMS.Models.Sanchalak", "Sanchalak")
                        .WithMany()
                        .HasForeignKey("SanchalakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Karyakar");

                    b.Navigation("Sanchalak");
                });

            modelBuilder.Entity("AMS.Models.Sanchalak", b =>
                {
                    b.HasOne("AMS.web.Models.Karyakar", "Karyakar")
                        .WithMany()
                        .HasForeignKey("KaryakarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMS.Models.Mandal", "Mandal")
                        .WithMany()
                        .HasForeignKey("MandalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Karyakar");

                    b.Navigation("Mandal");
                });

            modelBuilder.Entity("AMS.Models.Yuvak", b =>
                {
                    b.HasOne("AMS.Models.Mandal", "Mandal")
                        .WithMany()
                        .HasForeignKey("MandalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMS.Models.SamparkKaryakar", "SamparkKaryakar")
                        .WithMany()
                        .HasForeignKey("SamparkKaryakarId");

                    b.Navigation("Mandal");

                    b.Navigation("SamparkKaryakar");
                });

            modelBuilder.Entity("AMS.web.Models.Karyakar", b =>
                {
                    b.HasOne("AMS.web.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AMS.web.Models.Kshetra", b =>
                {
                    b.HasOne("AMS.web.Models.Karyakar", "Karyakar")
                        .WithMany()
                        .HasForeignKey("KaryakarId");

                    b.Navigation("Karyakar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
