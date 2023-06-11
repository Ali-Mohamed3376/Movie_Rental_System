using Microsoft.EntityFrameworkCore;
using MoveRentalSysytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.DBContext
{
    public class MRSContext : DbContext
    {
        // Containers
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer_Movie> Customer_Movies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-35F9698\SQLEXPRESS;Database=MovieRentalSystem;Trusted_Connection=true;TrustServerCertificate=true;Encrypt=false");
        }


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                // Configuration of columns
                entity.HasKey(x => x.CustomerId);

                entity.Property(x => x.CustomerId)
                     .ValueGeneratedNever()
                     .HasColumnType("int")
                     .HasMaxLength(10);

                entity.Property(x => x.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(x => x.LastName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(x => x.Address)
                    .IsRequired(false)
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(x => x.BirthDate)
                      .IsRequired()
                      .HasColumnType("date");

                entity.Property(x => x.PhoneNumber)
                    .HasColumnType("int")
                    .HasMaxLength(10);


                // Configuration of relations

                // one to many with Customer_Movie  ==> we do it in Customer_Movie configuration so i commented it here
                //entity.HasMany(x => x.Customer_Movies)
                //      .WithOne(x => x.Customer)
                //      .HasForeignKey(x => x.CustomerId);


            });


            #endregion

            #region Customer_Movie
            modelBuilder.Entity<Customer_Movie>(entity =>
            {
                // configuration of columns
                entity.HasKey(x => new { x.CustomerId, x.MovieId }); // Composite PK

                entity.Property(x => x.Date_Rented)
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(x => x.Due_Date)
                    .HasColumnType("datetime")
                    .IsRequired();

                // configuration of relations
                // M:M RelationShip
                entity.HasOne(x => x.Customer)
                    .WithMany(x => x.Customer_Movies)
                    .HasForeignKey(x => x.CustomerId);

                entity.HasOne(x => x.Movie)
                    .WithMany(x => x.Customer_Movies)
                    .HasForeignKey(x => x.MovieId);

            });
            #endregion

            #region Movie
            modelBuilder.Entity<Movie>(entity =>
            {
                // configuration of columns
                entity.HasKey(x => x.MovieId);

                entity.Property(x => x.MovieId)
                    .ValueGeneratedNever()
                    .HasColumnType("int")
                    .HasMaxLength(10);

                entity.Property(x => x.Movie_Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(x => x.Duration)
                    .HasColumnType("int")
                    .HasMaxLength(10)
                    .IsRequired();

                entity.Property(x => x.Rating)
                    .HasColumnType("char")
                    .HasMaxLength(1)
                    .IsRequired(false);


                // configuration of Relations
                // one to many with producer
                entity.HasOne(x => x.Producer)
                    .WithMany(x => x.Movies)
                    .HasForeignKey(x => x.ProducerId);
            });

            #endregion

            #region Producer
            modelBuilder.Entity<Producer>(entity =>
            {
                entity.HasKey(x => x.ProducerId);

                entity.Property(x => x.ProducerId)
                    .ValueGeneratedNever()
                    .HasColumnType("int")
                    .HasMaxLength(10);

                entity.Property(x => x.CompanyName)
                    .HasColumnType("varchar")
                    .HasMaxLength(200)
                    .IsRequired();
                entity.Property(x => x.Country)
                    .HasColumnType("varchar")
                    .HasMaxLength(255)
                    .IsRequired();
            });
            #endregion

            var customers = Reposetory.GetCustomers;
            var producers = Reposetory.GetProducers;
            var Movies = Reposetory.GetMovies;
            var customer_Movies = Reposetory.Customer_Movies;

            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Producer>().HasData(producers);
            modelBuilder.Entity<Movie>().HasData(Movies);
            modelBuilder.Entity<Customer_Movie>().HasData(customer_Movies);
        } 


    }
}
