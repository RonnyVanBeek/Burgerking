using Burgerking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.ViewModels
{
    public class BurgersViewModel
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Broodje { get; set; }
        public string Vlees { get; set; }
        public string Saus { get; set; }

        public string BurgerSearch { get; set; }
        public List<Burgers> Burgers { get; set; }
    }
}