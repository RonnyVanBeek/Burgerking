using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.ViewModels
{
    public class DessertsViewModel
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public bool BevatSoja { get; set; }

        //public string BurgerSearch { get; set; }
        public List<DessertsViewModel> Desserts { get; set; }

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