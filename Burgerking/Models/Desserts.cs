using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.Models
{
    public class Desserts
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public bool BevatSoja { get; set; }

        public string Soja(bool soja)
        {
            string text = "";
            if (soja)
            {
                text = "Bevat soja!";
            }
            return text;
        }
    }
}