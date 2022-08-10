using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Helpers.TaksNo1
{
    public class MainConsole
    {
        public static void DisplayMainConsole()
        {
            Console.WriteLine("Hello!");

            var d = new DisplayHelper();
            d.DisplayControlPanel();


            Console.WriteLine("# Please enter pyramid base length (odd number for better display):");
            var pyramidBaseLength = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("# Please enter direction No. or name:");
            var direction = Console.ReadLine();

            var input = "";

            while (input != "quit")
            {
                d.DrawAstriskPyramid(Int32.Parse(pyramidBaseLength), direction);
                Console.WriteLine("# To repeat please enter 'repeat'.");
                Console.WriteLine("# To exit please enter 'quit'.");
                Console.WriteLine(" ");

                input = Console.ReadLine();
                if (input == "repeat")
                {
                    DisplayMainConsole();
                }
            }

        }
    }
}
