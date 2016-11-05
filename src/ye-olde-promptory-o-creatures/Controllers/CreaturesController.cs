﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}