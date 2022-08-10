using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Helpers.TaksNo1
{
    public class DisplayHelper
    {
        public void DrawAstriskPyramid(int BaseNo, string direction)
        {
            if (BaseNo % 2 != 0)
            {

                switch (direction)
                {
                    case "Up":
                        for (int i = 0; i < BaseNo; i++)
                        {
                            int numOfSpaces = (BaseNo - i) / 2;
                            // numOfAstrisks = i
                            if (i % 2 != 0)
                                Console.WriteLine(new string(' ', numOfSpaces) + new string('*', i));
                        }
                        break;

                    case "Down":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfSpaces = i / 2;
                            int numOfAstrisks = BaseNo - i;
                            if (numOfAstrisks % 2 != 0)
                                Console.WriteLine(new string(' ', numOfSpaces) + new string('*', numOfAstrisks));
                        }
                        break;

                    case "Right":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfAstrisks = i + 1;

                            if (i <= BaseNo / 2)
                                Console.WriteLine(new string('*', numOfAstrisks));
                            else
                                Console.WriteLine(new string('*', BaseNo - i));
                        }
                        break;

                    case "Left":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfAstrisks = i + 1;

                            if (i <= BaseNo / 2)
                                Console.WriteLine(new string('*', numOfAstrisks));
                            else
                                Console.WriteLine(new string('*', BaseNo - i));
                        }
                        break;
                }


            }
            else
            {
                throw new Exception("Number must be odd");
            }

        }
    }
}
