using System;
using System.Collections.Generic;
using System.Text;

namespace RandomComplementGenerator.Models
{
    public class ComplimentConfiguration
    {
        /// <summary>
        /// The users name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// How many items the user has generated a compliment
        /// </summary>
        public int? howMany { get; set; }

        /// <summary>
        /// {Currently In Construction}
        /// </summary>
        public List<string> favoriteCompliments { get; set; }
    }
}
