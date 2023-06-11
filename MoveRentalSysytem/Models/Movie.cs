using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Movie_Name { get; set; }
        public int Duration { get; set; }
        public char? Rating { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }


        public ICollection<Customer_Movie> Customer_Movies { get; set; } = new HashSet<Customer_Movie>();

        public override string ToString()
        {
            return $"{Movie_Name}";
        }

    }
}
