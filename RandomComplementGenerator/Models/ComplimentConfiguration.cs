using System;
using System.Collections.Generic;
using System.Text;

namespace RandomComplementGenerator.Models
{
    public class ComplimentConfiguration
    {
        public string name { get; set; }
        public int? howMany { get; set; }
        public List<string> favoriteCompliments { get; set; }
    }
}
