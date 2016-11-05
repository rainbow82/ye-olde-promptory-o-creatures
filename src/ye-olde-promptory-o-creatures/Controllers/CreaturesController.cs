using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Controllers
{
    public class CreaturesController : Controller
    {
        public ActionResult Detail()
        {
            var creatures = new Creatures()
            {
                CreatureType = "Winged",
                CreatureName = "Dragon",
                Location = "World Wide",
                Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
          
            return View(creatures);
           
        }

        public ActionResult RegistrationForm()
        {
           
            return View();
        }
    }
}