using Microsoft.EntityFrameworkCore;
using MoveRentalSysytem.DBContext;
using MoveRentalSysytem.Models;

namespace MoveRentalSysytem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MRSContext db = new MRSContext();
            db.Database.Migrate();

            #region Queries

            // Query -1-
            /// Top 3 Ranted Movie Names
            
            //var q1 = db.Movies.OrderByDescending(x => x.Rating).Take(3);
            //Console.WriteLine("Top 3 Movie Rating:");
            //foreach (var q in q1)
            //{
            //    Console.WriteLine($"\t--→ {q}");
            //}


            /// Query -2-
            ///Producer with most movies and movie count
            
            //var q2 = db.Producers.Select(p => new { Producer = p.CompanyName, MovieCount = p.Movies.Count }).OrderByDescending(p => p.MovieCount).First();
            //Console.WriteLine("Producer With Most Movies and Movie Count");
            //Console.WriteLine($"\t-- {q2.Producer}\t\t→ {q2.MovieCount}");



            //// Query -3-
            ///Customers Ordered By There Rental Count

            //var q3 = db.Customers.Include(x => x.Customer_Movies)
            //                     .Select(x => new { x.FirstName, RentalCount = x.Customer_Movies.Count })
            //                     .OrderBy(x => x.RentalCount);
            //Console.WriteLine("Customer   Rental Count\n");
            //foreach (var q in q3)
            //{
            //    Console.WriteLine($" {q.FirstName}\t→\t{q.RentalCount}");
            //}


            //// Query -4-
            ///Full Information About Rentals [ CustomerName, MovieName, RentDate, Over Due Remaining Dayes]
            
            //var q4 = db.Customer_Movies
            //            .Include(x => x.Customer)
            //            .Include(x => x.Movie)
            //            .Select(x => new
            //            {
            //                CustomerName = x.Customer.FirstName,
            //                MovieName = x.Movie.Movie_Name,
            //                RentDate = x.Date_Rented,
            //                DueDate = x.Due_Date,
            //                OverDueRemainingDayes = OverRemainingDayes(x.Date_Rented, x.Due_Date)
            //            });

            //foreach (var i in q4)
            //{
            //    Console.WriteLine(i);
            //}



            //// Query -5-
            /// Over Due Rentals [CustomerName, MovieName, RentDate, Sorted by oldest ]

            //var q5 = db.Customer_Movies
            //    .Where(x => x.Due_Date.Day < DateTime.Now.Day)
            //    .Select(x => new
            //    {
            //        CustomerName = x.Customer.FirstName,
            //        MovieName = x.Movie.Movie_Name,
            //        RentDate = x.Date_Rented,
            //        DueDate = x.Due_Date
            //    }).OrderBy(x => x.RentDate);


            //foreach (var i in q5)
            //{
            //    Console.WriteLine(i);
            //}

            //#endregion

            //db.SaveChanges();
        }
        public static int OverRemainingDayes(DateTime rented, DateTime due)
        {
            int rentedday = rented.Day;
            int dueday = due.Day;
            int thisday = DateTime.Now.Day;

            if (thisday > dueday)
            {

                return dueday - thisday;
            }
            else if (thisday == dueday)
            {
                return 0;
            }
            else
            {
                int totalReanteddayes = dueday - rentedday;
                int remainingDayes = totalReanteddayes - (thisday - rentedday);
                return remainingDayes;
                    
            }
        }
    }
}