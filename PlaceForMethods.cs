using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_WhiteBoardAssessment
{
    class PlaceForMethods
    {
      
        // Challenge 2
        public int Subtract (int a, int b)
        {
            int c = (a - b);
            return c;
        }

        // Challenge 3
        public void MadMaxName(string a, string b)
        {
            string c = $"{a} {b}";
            Console.WriteLine($"Your name in a MadMax scenario would be {c}! Welcome to the apocalypse {c}!!");
        }
    }
}
