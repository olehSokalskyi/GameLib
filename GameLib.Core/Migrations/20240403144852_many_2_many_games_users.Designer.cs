﻿// <auto-generated />
using System;
using GameLib.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameLib.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403144852_many_2_many_games_users")]
    partial class many_2_many_games_users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeveloperGame", b =>
                {
                    b.Property<Guid>("DevelopersGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GamesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DevelopersGuid", "GamesGuid");

                    b.HasIndex("GamesGuid");

                    b.ToTable("DeveloperGame");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<Guid>("GamesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesGuid", "GenresGuid");

                    b.HasIndex("GenresGuid");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GameLanguage", b =>
                {
                    b.Property<Guid>("GamesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LanguagesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesGuid", "LanguagesGuid");

                    b.HasIndex("LanguagesGuid");

                    b.ToTable("GameLanguage");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Developer", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Persent")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Game", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DiscountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("PublisherGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("DiscountId");

                    b.HasIndex("PublisherGuid");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Genre", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Language", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameGuid");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Platform", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameGuid");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Role", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("GameLib.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleGuid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.Property<Guid>("GamesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlatformsGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesGuid", "PlatformsGuid");

                    b.HasIndex("PlatformsGuid");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.Property<Guid>("GamesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesGuid", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("GameUser");
                });

            modelBuilder.Entity("DeveloperGame", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Developer", null)
                        .WithMany()
                        .HasForeignKey("DevelopersGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLanguage", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLib.Core.Entities.Game", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId");

                    b.HasOne("GameLib.Core.Entities.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Payment", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Rating", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", "Game")
                        .WithMany("Ratings")
                        .HasForeignKey("GameGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameLib.Core.Entities.User", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.Platform", null)
                        .WithMany()
                        .HasForeignKey("PlatformsGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.HasOne("GameLib.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLib.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLib.Core.Entities.Game", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Publisher", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameLib.Core.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("GameLib.Core.Entities.User", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
