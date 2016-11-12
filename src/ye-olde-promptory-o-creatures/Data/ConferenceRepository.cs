using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Data
{
    public class ConferenceRepository
    {
        private static Conference[] _conferences = new Conference[]
        {
            new Conference()
            {
                ConferenceName = "Dragon Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },

            new Conference()
            {
                ConferenceName = "BigFoot Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },

            new Conference()
            {
                ConferenceName = "Fairy Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },
        };

        public Conference[] GetConferences()
        {
            return _conferences;
        }

        public Conference GetConference(int id)
        {
            Conference c = null;

            foreach (var conference in _conferences)
            {
                if (conference.ConferenceId == id)
                {
                    c = conference;

                    break;
                }
            }
            return c;
        }

   
    }
}