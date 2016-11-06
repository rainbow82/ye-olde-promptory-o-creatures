using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net;
using System.Data.Entity;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Models
{
    public class Conferences
    {
        public int ConferenceId { get; set; }
        public string ConferneceName { get; set; }
        public DateTime ConferenceDate { get; set; }
    }

    public class ConferneceContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }

        public ConferneceContext()
        {
            Database.SetInitializer<ConferneceContext>(
                new MyInitializer()
                );
        }
    }

    public class MyInitializer : DropCreateDatabaseIfModelChanges<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            base.Seed(context);
            context.Conferences.Add(new Conference()
            {
                Name = "Unicorn Con",
                Date = 10/25/16
            });
            context.SaveChanges();
        }
    }

    class Conference
    {
    }
}