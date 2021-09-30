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
        public List<Burgers> burgers;
        public List<Desserts> desserts;

        public ConsumptieController()
        {
            burgers = new List<Burgers>();
            desserts = new List<Desserts>();

            burgers.Add(new Burgers()
            {
                Id = 1,
                Naam = "Plant-based Wopper",
                Prijs = 4.95,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise",
                Vlees = "Plantaardige steak"
            });
            burgers.Add(new Burgers()
            {
                Id = 2,
                Naam = "Ultimate bacon king",
                Prijs = 5.15,
                Broodje = "Baconbroodje",
                Saus = "Bacon saus",
                Vlees = "Spek"
            });
            burgers.Add(new Burgers()
            {
                Id = 3,
                Naam = "King deal chicken",
                Prijs = 4.35,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise & ketchup",
                Vlees = "Gepaneerde kip"
            });
            burgers.Add(new Burgers()
            {
                Id = 4,
                Naam = "Master Angus",
                Prijs = 4.95,
                Broodje = "Briochebroodje",
                Saus = "Mayonaise met mosterd",
                Vlees = "Angus rundsvlees"
            });
            burgers.Add(new Burgers()
            {
                Id = 5,
                Naam = "King deal beef",
                Prijs = 4.35,
                Broodje = "Sesambroodje",
                Saus = "Mayonaise & ketchup",
                Vlees = "Gegrild rundsvlees"
            });
            burgers.Add(new Burgers()
            {
                Id = 6,
                Naam = "Ultimate Chicken Bacon King",
                Prijs = 5.35,
                Broodje = "Baconbroodje",
                Saus = "Baconsaus",
                Vlees = "Kip & spek"
            });

            desserts.Add(new Desserts()
            {
                Id = 1,
                Naam = "BK Fusions",
                Prijs = 2.75,
                BevatSoja = true
            });
            desserts.Add(new Desserts()
            {
                Id = 2,
                Naam = "Donuts",
                Prijs = 2.45,
                BevatSoja = true
            });
            desserts.Add(new Desserts()
            {
                Id = 3,
                Naam = "Mini pancakes",
                Prijs = 2.95,
                BevatSoja = false
            });
        }

        public IActionResult BurgerOverzicht()
        {
            BurgersViewModel viewModel = new BurgersViewModel();
            viewModel.Burgers = burgers;
            return View(viewModel);
        }

        public IActionResult SearchBurger(BurgersViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.BurgerSearch))
            {
                string zoek = viewModel.BurgerSearch.ToLower();
                viewModel.Burgers = burgers.Where(b => b.Naam.ToLower().Contains(zoek)).ToList();
            }
            else
            {
                viewModel.Burgers = burgers;
            }
            return View("BurgerOverzicht", viewModel);
        }

        public IActionResult SearchDessert(DessertsViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.DessertSearch))
            {
                string zoek = viewModel.DessertSearch.ToLower();
                viewModel.Desserts = desserts.Where(b => b.Naam.ToLower().Contains(zoek)).ToList();
            }
            else
            {
                viewModel.Desserts = desserts;
            }
            return View("DessertOverzicht", viewModel);
        }

        public IActionResult DessertOverzicht()
        {
            DessertsViewModel viewModel = new DessertsViewModel();
            viewModel.Desserts = desserts;
            return View(viewModel);
        }

        public IActionResult BurgerDetails(int id)
        {
            Burgers burger = burgers.Where(b => b.Id == id).FirstOrDefault();

            if (burger != null)
            {
                BurgersViewModel viewModel = new BurgersViewModel()
                {
                    Naam = burger.Naam,
                    Prijs = burger.Prijs,
                    Broodje = burger.Broodje,
                    Saus = burger.Saus,
                    Vlees = burger.Vlees
                };
                return View(viewModel);
            }
            else
            {
                BurgersViewModel vm = new BurgersViewModel();
                vm.Burgers = burgers;
                return View("BurgerOverzicht", vm);
            }
        }

        public IActionResult DessertDetails(int id)
        {
            Desserts dessert = desserts.Where(d => d.Id == id).FirstOrDefault();

            if (dessert != null)
            {
                DessertsViewModel viewModel = new DessertsViewModel()
                {
                    Naam = dessert.Naam,
                    Prijs = dessert.Prijs,
                    BevatSoja = dessert.BevatSoja
                };
                return View(viewModel);
            }
            else
            {
                DessertsViewModel vm = new DessertsViewModel();
                vm.Desserts = desserts;
                return View("DessertsOverzicht", vm);
            }
        }
    }
}