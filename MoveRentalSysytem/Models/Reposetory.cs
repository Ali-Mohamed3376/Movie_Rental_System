using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.Models
{
    public static class Reposetory
    {
        public static HashSet<Customer> GetCustomers = new HashSet<Customer>()
        {
            new Customer() { CustomerId =1 , FirstName = "Ali", LastName = "Moh.", Address = "Sharqia", BirthDate = new DateTime(1999, 04, 10), PhoneNumber     = 1123702048},
            new Customer() { CustomerId =2 , FirstName = "Reem", LastName = "Issam.", Address = "Cairo", BirthDate = new DateTime(2000, 08, 20), PhoneNumber    = 1023521021},
            new Customer() { CustomerId =3 , FirstName = "Adel", LastName = "Makram", Address = "Aswaan", BirthDate = new DateTime(1995, 02, 7), PhoneNumber    = 1023521021},
            new Customer() { CustomerId =4 , FirstName = "Ahmed", LastName = "Helmy", Address = "Helwan", BirthDate = new DateTime(1999, 05, 30), PhoneNumber   = 1023521021},
            new Customer() { CustomerId =5 , FirstName = "Sawsan", LastName = "Bader", Address = "Daqhlia", BirthDate = new DateTime(2003, 04, 27), PhoneNumber = 1254875212},
        };

        public static HashSet<Producer> GetProducers = new HashSet<Producer>()
        {
            new Producer() { ProducerId = 1 , CompanyName = "Al Adel Group", Country = "Syrya"},
            new Producer() { ProducerId = 2 , CompanyName = "Synergy", Country = "Egypt"},
            new Producer() { ProducerId = 3 , CompanyName = "Al Zahraa", Country = "Libya"},
            new Producer() { ProducerId = 4 , CompanyName = "Maspiro", Country = "Egypt"},
            new Producer() { ProducerId = 5 , CompanyName = "Tamer Hosny Group", Country = "Russia"},
            new Producer() { ProducerId = 6 , CompanyName = "Ali Baba", Country = "Egypt"},

        };

        public static HashSet<Movie> GetMovies = new HashSet<Movie>()
        {
            new Movie(){ MovieId = 1, Movie_Name = "El Kaief",   Duration = 2, Rating= 5, ProducerId = 1},
            new Movie(){ MovieId = 2, Movie_Name = "El Ghwass",  Duration = 1, Rating= 7, ProducerId = 2},
            new Movie(){ MovieId = 3, Movie_Name = "KarKar",     Duration = 3, Rating= 9, ProducerId = 2},
            new Movie(){ MovieId = 4, Movie_Name = "El Guass",   Duration = 2, Rating= 10, ProducerId = 3},
            new Movie(){ MovieId = 5, Movie_Name = "El Hroup"  , Duration = 4, Rating= 3, ProducerId = 4},
            new Movie(){ MovieId = 6, Movie_Name = "Kalb Balady",Duration = 1, Rating= 8, ProducerId = 1},
            new Movie(){ MovieId = 7, Movie_Name = "El Qurmoty", Duration = 3, Rating= 6, ProducerId = 5},
            new Movie(){ MovieId = 8, Movie_Name = "Hanfy El Obha",Duration = 2, Rating= 5, ProducerId = 4},
            new Movie(){ MovieId = 9, Movie_Name = "Kabab Mashwy", Duration = 2, Rating= 7, ProducerId = 5},
            new Movie(){ MovieId = 10, Movie_Name = "Amir El Zalam", Duration = 3, Rating= 10, ProducerId = 6},
        };

        public static HashSet<Customer_Movie> Customer_Movies = new HashSet<Customer_Movie>()
        {
            new Customer_Movie(){ CustomerId = 1, MovieId = 1, Date_Rented = new DateTime(2023, 06, 02), Due_Date = new DateTime(2023, 06, 30)},
            new Customer_Movie(){ CustomerId = 2, MovieId = 2, Date_Rented = new DateTime(2023, 06, 05), Due_Date = new DateTime(2023, 06, 20)},
            new Customer_Movie(){ CustomerId = 3, MovieId = 3, Date_Rented = new DateTime(2023, 06, 03), Due_Date = new DateTime(2023, 06, 25)},
            new Customer_Movie(){ CustomerId = 1, MovieId = 4, Date_Rented = new DateTime(2023, 06, 05), Due_Date = new DateTime(2023, 06, 10)},
            new Customer_Movie(){ CustomerId = 5, MovieId = 5, Date_Rented = new DateTime(2023, 06, 08), Due_Date = new DateTime(2023, 06, 30)},
            new Customer_Movie(){ CustomerId = 5, MovieId = 6, Date_Rented = new DateTime(2023, 06, 09), Due_Date = new DateTime(2023, 06, 28)},
            new Customer_Movie(){ CustomerId = 4, MovieId = 7, Date_Rented = new DateTime(2023, 06, 04), Due_Date = new DateTime(2023, 06, 05)},
            new Customer_Movie(){ CustomerId = 4, MovieId = 8, Date_Rented = new DateTime(2023, 06, 02), Due_Date = new DateTime(2023, 06, 20)},
            new Customer_Movie(){ CustomerId = 2, MovieId = 9, Date_Rented = new DateTime(2023, 06, 03), Due_Date = new DateTime(2023, 06, 30)},
            new Customer_Movie(){ CustomerId = 1, MovieId = 10, Date_Rented= new DateTime(2023, 06, 10), Due_Date = new DateTime(2023, 06, 19)},
            new Customer_Movie(){ CustomerId = 4, MovieId = 5, Date_Rented= new DateTime(2023, 06, 01), Due_Date = new DateTime(2023, 06, 09)},
            new Customer_Movie(){ CustomerId = 3, MovieId = 10, Date_Rented= new DateTime(2023, 06, 01), Due_Date = new DateTime(2023, 06, 07)},
        };
    }
}
