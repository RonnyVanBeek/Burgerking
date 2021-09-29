using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.Models
{
    public class Burgers
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Broodje { get; set; }
        public string Vlees { get; set; }
        public string Saus { get; set; }
    }
}