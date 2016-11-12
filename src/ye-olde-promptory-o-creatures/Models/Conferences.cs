﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net;
using System.Data.Entity;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Models
{
    public class Conference
    {
        public int ConferenceId { get; set; }
        public string ConferenceName { get; set; }
        public DateTime ConferenceDate { get; set; }
    }

    public class ConferenceContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }

        public ConferenceContext()
        {
            Database.SetInitializer<ConferenceContext>(
                new MyInitializer()
                );
        }
    }

    public class MyInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            base.Seed(context);
            context.Conferences.Add(new Conference()
            {
                ConferenceName = "Unicorn Con",
                ConferenceDate = new DateTime(2016,04,01),
            });
            context.SaveChanges();
        }
    }

   
}