using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.Models
{
    public class Customer
    {
        #region Properties
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int PhoneNumber { get; set; }


        public ICollection<Customer_Movie> Customer_Movies { get; set; } = new HashSet<Customer_Movie>();
        #endregion

        #region Constructors
        public Customer()
        {
            
        }

        public Customer(int customerId, string firstName, string lastName, string address, DateTime birthDate, int phoneNumber)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region Override ToString()
        //public override string ToString()
        //{
        //    return $"{CustomerId}:{FirstName}:{LastName}:{Address}:{BirthDate}:{PhoneNumber}";
        //}
        #endregion
    }
}
