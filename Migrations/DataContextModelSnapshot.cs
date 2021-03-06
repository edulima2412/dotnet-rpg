﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

namespace dotnet_rpg.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 2,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 3,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 },
                            PasswordSalt = new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 },
                            Role = "Admin",
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 },
                            PasswordSalt = new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 3,
                            PasswordHash = new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 },
                            PasswordSalt = new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.HasOne("dotnet_rpg.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.Models.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Navigation("CharacterSkills");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Navigation("CharacterSkills");
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
