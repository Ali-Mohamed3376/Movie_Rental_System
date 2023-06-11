﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoveRentalSysytem.DBContext;

#nullable disable

namespace MoveRentalSysytem.Migrations
{
    [DbContext(typeof(MRSContext))]
    partial class MRSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Sharqia",
                            BirthDate = new DateTime(1999, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ali",
                            LastName = "Moh.",
                            PhoneNumber = 1123702048
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Cairo",
                            BirthDate = new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Reem",
                            LastName = "Issam.",
                            PhoneNumber = 1023521021
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Aswaan",
                            BirthDate = new DateTime(1995, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Adel",
                            LastName = "Makram",
                            PhoneNumber = 1023521021
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "Helwan",
                            BirthDate = new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ahmed",
                            LastName = "Helmy",
                            PhoneNumber = 1023521021
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "Daqhlia",
                            BirthDate = new DateTime(2003, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sawsan",
                            LastName = "Bader",
                            PhoneNumber = 1254875212
                        });
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

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            MovieId = 1,
                            Date_Rented = new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 2,
                            MovieId = 2,
                            Date_Rented = new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 3,
                            MovieId = 3,
                            Date_Rented = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 1,
                            MovieId = 4,
                            Date_Rented = new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 5,
                            MovieId = 5,
                            Date_Rented = new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 5,
                            MovieId = 6,
                            Date_Rented = new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            MovieId = 7,
                            Date_Rented = new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            MovieId = 8,
                            Date_Rented = new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 2,
                            MovieId = 9,
                            Date_Rented = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 1,
                            MovieId = 10,
                            Date_Rented = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            MovieId = 5,
                            Date_Rented = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 3,
                            MovieId = 10,
                            Date_Rented = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Due_Date = new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.Property<string>("Rating")
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.HasKey("MovieId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Duration = 2,
                            Movie_Name = "El Kaief",
                            ProducerId = 1,
                            Rating = "D"
                        },
                        new
                        {
                            MovieId = 2,
                            Duration = 1,
                            Movie_Name = "El Ghwass",
                            ProducerId = 2,
                            Rating = "B"
                        },
                        new
                        {
                            MovieId = 3,
                            Duration = 3,
                            Movie_Name = "KarKar",
                            ProducerId = 2,
                            Rating = "E"
                        },
                        new
                        {
                            MovieId = 4,
                            Duration = 2,
                            Movie_Name = "El Guass",
                            ProducerId = 3,
                            Rating = "C"
                        },
                        new
                        {
                            MovieId = 5,
                            Duration = 4,
                            Movie_Name = "El Hroup",
                            ProducerId = 4,
                            Rating = "A"
                        },
                        new
                        {
                            MovieId = 6,
                            Duration = 1,
                            Movie_Name = "Kalb Balady",
                            ProducerId = 1,
                            Rating = "E"
                        },
                        new
                        {
                            MovieId = 7,
                            Duration = 3,
                            Movie_Name = "El Qurmoty",
                            ProducerId = 5,
                            Rating = "D"
                        },
                        new
                        {
                            MovieId = 8,
                            Duration = 2,
                            Movie_Name = "Hanfy El Obha",
                            ProducerId = 4,
                            Rating = "A"
                        },
                        new
                        {
                            MovieId = 9,
                            Duration = 2,
                            Movie_Name = "Kabab Mashwy",
                            ProducerId = 5,
                            Rating = "D"
                        },
                        new
                        {
                            MovieId = 10,
                            Duration = 3,
                            Movie_Name = "Amir El Zalam",
                            ProducerId = 6,
                            Rating = "A"
                        });
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

                    b.HasData(
                        new
                        {
                            ProducerId = 1,
                            CompanyName = "Al Adel Group",
                            Country = "Syrya"
                        },
                        new
                        {
                            ProducerId = 2,
                            CompanyName = "Synergy",
                            Country = "Egypt"
                        },
                        new
                        {
                            ProducerId = 3,
                            CompanyName = "Al Zahraa",
                            Country = "Libya"
                        },
                        new
                        {
                            ProducerId = 4,
                            CompanyName = "Maspiro",
                            Country = "Egypt"
                        },
                        new
                        {
                            ProducerId = 5,
                            CompanyName = "Tamer Hosny Group",
                            Country = "Russia"
                        },
                        new
                        {
                            ProducerId = 6,
                            CompanyName = "Ali Baba",
                            Country = "Egypt"
                        });
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
