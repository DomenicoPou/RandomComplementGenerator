using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomComplementGenerator.Models
{
    public class ComplimentComponents
    {
        public List<string> Bridge { get; set; }
        public NormalComponents NormalComponents { get; set; }
        public GreetingComponents GreetingComponents { get; set; }
        public List<string> NormalCompliments { get; set; }
        public Dictionary<string, int> praiseCombinations { get; set; }
    }

    public class GreetingComponents
    {
        public List<string> Morning { get; set; }
        public List<string> Afternoon { get; set; }
        public List<string> Normal { get; set; }
    }

    public class NormalComponents
    {
        public List<string> Single { get; set; }
        public List<string> Suffix { get; set; }
        public List<string> Prefix { get; set; }
    }
}
