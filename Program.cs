using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_WhiteBoardAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaceForMethods methods = new PlaceForMethods();

            // Challenge 1
            int apples = 23;
            string oranges = "Oranges!";
            DateTime picked = new DateTime(2020, 7,1);

            // Challenge 2 used
            Console.WriteLine(methods.Subtract(8, 4));

            // Challenge 3 used
            Console.Write("What was the last thing you ate?: ");
            string ate = Console.ReadLine();
            Console.Write("What was your first pet's name?: ");
            string pet = Console.ReadLine();
            methods.MadMaxName(pet, ate);

            // Challenge 4
            Console.Write("Are you wearing clothes? Y/N: ");

            string answer = Console.ReadLine();
            string ansLow = answer.ToLower();
            switch (ansLow)
            {
                case "y":
                    Console.WriteLine("Good");
                    break;
                case "n":
                    Console.WriteLine("Put some clothes on!");
                    break;
                default:
                    Console.WriteLine("Please answer with a Y or N");
                    break;
            }

            // Challenge 5
            bool happy = true;
            Console.Write("Are you happy? Y/N: ");
            string happi = Console.ReadLine();
            string happiness = happi.ToLower();
            if (happiness == "y")
            {
                happy = true;

            }
            else if (happiness == "n")
            {
                happy = false;
            }
            else
            {
                Console.WriteLine("Please answer with an Y or N");
            }
            Console.WriteLine(happy == true ? "Glad to hear!" : "Sorry to hear that");
            
            // Challenge 6
            Console.Write("Tell me what you make annually for some appropriate financial advice: $");
            int moolah = Int32.Parse(Console.ReadLine());

            if (moolah > 100000)
            {
                Console.WriteLine("You should probably have a real financial advisor.");
            }
            else if (moolah <= 100000 && moolah >= 51000)
            {
                Console.WriteLine("Invest in a home and build some equity.");
            }
            else if (moolah < 51000 && moolah >= 11000)
            {
                Console.WriteLine("Invest in stocks. Check them everyday.");
            }
            else if (moolah >= 1000 && moolah < 11000)
            {
                Console.WriteLine("Invest in BitCoin. Check it every five minutes.");

            }
            else if (moolah > 0 && moolah < 1000)
            {
                Console.WriteLine("Buy some Lottery tickets. Hopefully it'll work out.");
            }
            else if (moolah == 0)
            {
                Console.WriteLine("That's rough buddy.");
            }
            else
            {
                Console.WriteLine("Please enter a positve value");
            }
            Console.ReadLine();
        }
    }
}
