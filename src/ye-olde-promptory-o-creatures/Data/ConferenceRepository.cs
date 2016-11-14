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
        private static Conferences[] _conferences = new Conferences[]
        {
            new Conferences()
            {
                ConferenceName = "Dragon Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },

            new Conferences()
            {
                ConferenceName = "BigFoot Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },

            new Conferences()
            {
                ConferenceName = "Fairy Con",
                ConferenceDate = new DateTime(2016, 10, 31)
            },
        };

        public Conferences[] GetConferences()
        {
            return _conferences;
        }

        public Conferences GetConference(int id)
        {
            Conferences c = null;

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

        public void AddConference(Conferences conference)
        {
            // Get the next available entry ID.
            int nextAvailableEntryId = _conferences.Max(x => x.ConferenceId)+1;

            conference.ConferenceId = nextAvailableEntryId;

            var conferences2 = new Conferences[_conferences.Length + 1];
            for (int i=0; i<_conferences.Length; i++)
            {
                conferences2[i] = _conferences[i];
            }
            conferences2[_conferences.Length] = conference;
            _conferences = conferences2; 


            // Add(conference);
        }

        private static void Add(Conferences conference)
        {
            throw new NotImplementedException();
        }

        private static int Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}