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
        private ConferenceRepository _conferenceRepository = null;

        public DateTime Date { get; private set; }

        public CreaturesController()
        {
            _creatureRepository = new CreatureRepository();
            _conferenceRepository = new ConferenceRepository();
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
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationForm(string firstName, string lastName, string email)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            return View();
        }

        public ActionResult Upcoming()
        {
            var conferences = _conferenceRepository.GetConferences();
            return View(conferences);
        }

        public ActionResult Add()
        {
            var conference = new Conferences();
            {
                Date = DateTime.Today;
            };
            return View(conference);
        }

        [HttpPost]
        public ActionResult Add(Conferences conference)
        {
            if (ModelState.IsValid)
            {
                _conferenceRepository.AddConference(conference);

                return RedirectToAction("Index");
            }
            return View(conference);
        }
    }

   
}