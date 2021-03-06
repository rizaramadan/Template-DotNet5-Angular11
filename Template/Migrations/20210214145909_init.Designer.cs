﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Template.Data.Context;

namespace Template.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210214145909_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Template.Domain.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("integer");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Sequence")
                        .HasColumnType("integer");

                    b.Property<string>("URL")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedUser = 0,
                            Icon = "dashboard.png",
                            IsActive = true,
                            Name = "Dashboard",
                            Sequence = 1,
                            URL = "dashboard",
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedUser = 0,
                            Icon = "users.png",
                            IsActive = true,
                            Name = "Users",
                            Sequence = 2,
                            URL = "users",
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedUser = 0,
                            Icon = "accounts.png",
                            IsActive = true,
                            Name = "Account",
                            Sequence = 3,
                            URL = "accounts",
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Template.Domain.Entities.ModuleProfile", b =>
                {
                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfileId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleId", "ProfileId");

                    b.HasIndex("ProfileId");

                    b.ToTable("ModuleProfiles");

                    b.HasData(
                        new
                        {
                            ModuleId = 1,
                            ProfileId = 1
                        },
                        new
                        {
                            ModuleId = 2,
                            ProfileId = 1
                        },
                        new
                        {
                            ModuleId = 3,
                            ProfileId = 1
                        },
                        new
                        {
                            ModuleId = 1,
                            ProfileId = 2
                        },
                        new
                        {
                            ModuleId = 3,
                            ProfileId = 2
                        });
                });

            modelBuilder.Entity("Template.Domain.Entities.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedUser = 0,
                            IsActive = true,
                            IsDefault = false,
                            Name = "Admin",
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedUser = 0,
                            IsActive = true,
                            IsDefault = true,
                            Name = "User",
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Template.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsAuthorised")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("ProfileId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 2, 14, 21, 59, 8, 947, DateTimeKind.Local).AddTicks(4467),
                            CreatedUser = 1,
                            Email = "admin@template.com",
                            IsActive = true,
                            IsAuthorised = true,
                            Name = "Admin",
                            Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C",
                            ProfileId = 1,
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 2, 14, 21, 59, 8, 948, DateTimeKind.Local).AddTicks(2930),
                            CreatedUser = 1,
                            Email = "user@template.com",
                            IsActive = true,
                            IsAuthorised = true,
                            Name = "User",
                            Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C",
                            ProfileId = 2,
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Template.Domain.Entities.ModuleProfile", b =>
                {
                    b.HasOne("Template.Domain.Entities.Module", "Module")
                        .WithMany("Profiles")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Template.Domain.Entities.Profile", "Profile")
                        .WithMany("Modules")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Template.Domain.Entities.User", b =>
                {
                    b.HasOne("Template.Domain.Entities.Profile", "Profile")
                        .WithMany("Users")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Template.Domain.Entities.Module", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("Template.Domain.Entities.Profile", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
