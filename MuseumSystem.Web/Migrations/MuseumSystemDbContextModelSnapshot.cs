﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuseumSystem.Core;

#nullable disable

namespace MuseumSystem.Web.Migrations
{
    [DbContext(typeof(MuseumSystemDbContext))]
    partial class MuseumSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MuseumSystem.Core.Models.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdmin"));

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MuseumId")
                        .HasColumnType("int");

                    b.HasKey("IdAdmin");

                    b.HasIndex("MuseumId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvent"));

                    b.Property<int>("AgeRating")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("MuseumId")
                        .HasColumnType("int");

                    b.Property<string>("NameEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PreferentialPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<decimal?>("RetirementPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("SlugEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEvent");

                    b.HasIndex("MuseumId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.ImageEvent", b =>
                {
                    b.Property<int>("IdImageEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdImageEvent"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("NamePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdImageEvent");

                    b.HasIndex("EventId");

                    b.ToTable("ImageEvents");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Museum", b =>
                {
                    b.Property<int>("IdMuseum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMuseum"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlugMuseum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMuseum");

                    b.ToTable("Museums");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Record", b =>
                {
                    b.Property<int>("IdRecord")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRecord"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRecord");

                    b.HasIndex("EventId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.RecordClient", b =>
                {
                    b.Property<int>("IdRecordClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRecordClient"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("RecordId")
                        .HasColumnType("int");

                    b.Property<decimal>("RecordPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("IdRecordClient");

                    b.HasIndex("ClientId");

                    b.HasIndex("RecordId");

                    b.ToTable("RecordClients");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Admin", b =>
                {
                    b.HasOne("MuseumSystem.Core.Models.Museum", "Museum")
                        .WithMany("Admins")
                        .HasForeignKey("MuseumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Museum");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Event", b =>
                {
                    b.HasOne("MuseumSystem.Core.Models.Museum", "Museum")
                        .WithMany("Events")
                        .HasForeignKey("MuseumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Museum");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.ImageEvent", b =>
                {
                    b.HasOne("MuseumSystem.Core.Models.Event", "Event")
                        .WithMany("ImageEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Record", b =>
                {
                    b.HasOne("MuseumSystem.Core.Models.Event", "Event")
                        .WithMany("Records")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.RecordClient", b =>
                {
                    b.HasOne("MuseumSystem.Core.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MuseumSystem.Core.Models.Record", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Event", b =>
                {
                    b.Navigation("ImageEvents");

                    b.Navigation("Records");
                });

            modelBuilder.Entity("MuseumSystem.Core.Models.Museum", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
