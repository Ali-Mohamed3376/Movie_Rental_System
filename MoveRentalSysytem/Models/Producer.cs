﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveRentalSysytem.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();

        public override string ToString()
        {
            return $"{ProducerId}:{CompanyName}:{Country}";
        }
    }
}
