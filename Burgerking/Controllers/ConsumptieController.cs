using Burgerking.Models;
using Burgerking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.Controllers
{
    public class ConsumptieController : Controller
    {
        public List<BurgersViewModel> burgers;

        public ConsumptieController()
        {
            burgers = new List<BurgersViewModel>();
            burgers.Add(new BurgersViewModel()
            {
                Naam = "Plant-based Wopper",
                Prijs = 4.95,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise",
                Vlees = "Plantaardige steak"
            });
            burgers.Add(new BurgersViewModel()
            {
                Naam = "Ultimate bacon king",
                Prijs = 5.15,
                Broodje = "Baconbroodje",
                Saus = "Bacon saus",
                Vlees = "Spek"
            });
            burgers.Add(new BurgersViewModel()
            {
                Naam = "King deal chicken",
                Prijs = 4.35,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise & ketchup",
                Vlees = "Gepaneerde kip"
            });
            burgers.Add(new BurgersViewModel()
            {
                Naam = "Master Angus",
                Prijs = 4.95,
                Broodje = "Briochebroodje",
                Saus = "Mayonaise met mosterd",
                Vlees = "Angus rundsvlees"
            });
            burgers.Add(new BurgersViewModel()
            {
                Naam = "King deal beef",
                Prijs = 4.35,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise & ketchup",
                Vlees = "Gegrild rundsvlees"
            });
            burgers.Add(new BurgersViewModel()
            {
                Naam = "Ultimate Chicken Bacon King",
                Prijs = 5.35,
                Broodje = "Baconbroodje",
                Saus = "Baconsaus",
                Vlees = "Kip & spek"
            });
        }

        public IActionResult BurgerOverzicht()
        {
            BurgersViewModel viewModel = new BurgersViewModel();
            viewModel.Burgers = burgers;
            return View(viewModel);
        }
    }
}