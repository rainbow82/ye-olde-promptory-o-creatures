using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ye_olde_promptory_o_creatures.Models
{
    public class Creatures
    {
        public int Id { get; set; }
        public string CreatureType { get; set; }
        public string CreatureName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public string DisplayText
        {
            get
            {
                return CreatureName;
            }
        }

        public string ImageFileName
        {
            get
            {
                return CreatureType.Replace(" ", "-")
                    .ToLower() + "-" + CreatureName + ".jpg";
            }
        }

      
    }//end class

   
}