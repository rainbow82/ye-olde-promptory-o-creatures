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
            
               ViewBag.CreatureName = "Dragon";
               ViewBag.Location = "World Wide";
               ViewBag.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum lectus augue. Nunc egestas augue et sem semper placerat. Sed mollis auctor dignissim. Sed risus justo, fringilla vitae facilisis ut, rutrum non odio. Maecenas commodo turpis in porttitor placerat. In congue neque eget lacinia tempus. ";
            var creatures = new Creatures()
            {
                //CreatureName = "Dragon",
                //Location = "World Wide",
                // Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
          
            return View(creatures);
           
        }

        public ActionResult RegistrationForm()
        {
           
            return View();
        }
    }
}