using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ye_olde_promptory_o_creatures.Models;

namespace ye_olde_promptory_o_creatures.Data
{
    public class CreatureRepository
    {
        private static Creatures[] _creatures = new Creatures[]
        {
            new Creatures()
            {
                Id = 1,
                CreatureType = "Winged",
                CreatureName = "Dragon",
                Location = "World Wide",
                Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },

            new Creatures()
            {
                Id = 2,
                CreatureType = "Winged",
                CreatureName = "Fairy",
                Location = "World Wide",
                Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },

            new Creatures()
            {
                Id = 3,
                CreatureType = "Mountainous",
                CreatureName = "BigFoot",
                Location = "World Wide",
                Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
        };

        public Creatures[] GetCreatures()
        {
            return _creatures;
        } 

        public Creatures GetCreature(int id)
        {
            Creatures creatures = null;

            foreach (var creature in _creatures)
            {
                if (creature.Id == id)
                {
                    creatures = creature;

                    break;
                }
            }
            return creatures;
        }
    }
}