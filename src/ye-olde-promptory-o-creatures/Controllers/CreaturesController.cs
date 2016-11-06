using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using ye_olde_promptory_o_creatures.Data;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Controllers
{
    public class CreaturesController : Controller
    {
        private CreatureRepository _creatureRepository = null;

        public CreaturesController()
        {
            _creatureRepository = new CreatureRepository();
        }

        //display home page
        public ActionResult Index()
        {
            var creatures = _creatureRepository.GetCreatures();

            return View(creatures);
        }

        //display detail page
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var creatures = _creatureRepository.GetCreature(id.Value);
          
            return View(creatures);
           
        }

        public ActionResult RegistrationForm()
        {
            var creatures = _creatureRepository.GetCreatures();
            return View(creatures);
        }

        public ActionResult Upcoming()
        {
            var creatures = _creatureRepository.GetCreatures();
            return View(creatures);
        }
    }
}