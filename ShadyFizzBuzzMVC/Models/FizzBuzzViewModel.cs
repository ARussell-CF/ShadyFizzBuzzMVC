using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadyFizzBuzzMVC.Models
{
    public class FizzBuzzViewModel
    {
        //I need:
        //FizzValue
        public int FizzValue { get; set; } = 3;

        //BuzzValue
        public int BuzzValue { get; set; }

        //A way to output my results
        public List<string> Results { get; set; } = new List<string>();

    }
}
