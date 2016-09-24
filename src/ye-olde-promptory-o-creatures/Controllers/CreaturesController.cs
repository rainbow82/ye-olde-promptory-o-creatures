using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ye_olde_promptory_o_creatures.Controllers
{
    public class CreaturesController :Controller
    {
        public ActionResult Detail()
        {
            //using properties instead of variables
            ViewBag.CreatureName = "Dragon";
            ViewBag.Location = "World Wide";
            ViewBag.Description = "A huge neck runs down from its head and into a narrow body. The top is covered in rounded scales and a row of small fan-like growths runs down its spine. \n " +
        "Its bottom is covered in coarse skin and is colored much lighter than the rest of its body. \n " +
        "Four long limbs carry its body and allow the creature to stand towering and noble. Each limb has 6 digits, each of which end in thick nails seemingly made of obsidian. ";

            return View();
           
        }
    }
}