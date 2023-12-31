﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoveRentalSysytem.DBContext;

#nullable disable

namespace MoveRentalSysytem.Migrations
{
    [DbContext(typeof(MRSContext))]
    [Migration("20230612185025_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MoveRentalSysytem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<int>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Customer_Movie", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Rented")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Due_Date")
                        .HasColumnType("datetime");

                    b.HasKey("CustomerId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Customer_Movies");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Movie_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Customer_Movie", b =>
                {
                    b.HasOne("MoveRentalSysytem.Models.Customer", "Customer")
                        .WithMany("Customer_Movies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoveRentalSysytem.Models.Movie", "Movie")
                        .WithMany("Customer_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Movie", b =>
                {
                    b.HasOne("MoveRentalSysytem.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Customer", b =>
                {
                    b.Navigation("Customer_Movies");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Movie", b =>
                {
                    b.Navigation("Customer_Movies");
                });

            modelBuilder.Entity("MoveRentalSysytem.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
