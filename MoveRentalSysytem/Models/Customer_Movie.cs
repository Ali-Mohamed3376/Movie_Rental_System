using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.Models
{
    public class Customer_Movie
    {
        #region Properties
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime Date_Rented { get; set; }
        public DateTime Due_Date { get; set; }
        #endregion

        #region Override ToString()

        //public override string ToString()
        //{
        //    return $"{CustomerId}:{MovieId}{}:{}{}:{}";
        //}

        #endregion
    }
}
