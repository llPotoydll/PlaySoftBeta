﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PlaySoftBeta.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaySoftBeta.Models.Playlist", b =>
                {
                    b.Property<int>("playlistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("playlistID"));

                    b.Property<string>("playListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("privacity")
                        .HasColumnType("bit");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("playlistID");

                    b.HasIndex("userID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.Song", b =>
                {
                    b.Property<int>("songID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("songID"));

                    b.Property<decimal>("duration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("playlistID")
                        .HasColumnType("int");

                    b.Property<string>("songName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("songID");

                    b.HasIndex("playlistID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.Playlist", b =>
                {
                    b.HasOne("PlaySoftBeta.Models.User", null)
                        .WithMany("allPlayLists")
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.Song", b =>
                {
                    b.HasOne("PlaySoftBeta.Models.Playlist", null)
                        .WithMany("allSongs")
                        .HasForeignKey("playlistID");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.Playlist", b =>
                {
                    b.Navigation("allSongs");
                });

            modelBuilder.Entity("PlaySoftBeta.Models.User", b =>
                {
                    b.Navigation("allPlayLists");
                });
#pragma warning restore 612, 618
        }
    }
}
