
namespace CSharp.ProblemSolving.Tasks.TaksNo1
{
    public class DisplayHelper
    {
        public void DisplayControlPanel()
        {
            Console.WriteLine("# You need to enter pyramid base length and direction");
            Console.WriteLine(" ");
            Console.WriteLine("# Here are your direction control keys");
            Console.WriteLine("     1 - Rotate left");
            Console.WriteLine("     2 - Rotate up");
            Console.WriteLine("     3 - Rotate right");
            Console.WriteLine("     4 - Rotate down");
            Console.WriteLine(" ");
        }
        public void DrawAstriskPyramid(int BaseNo, string direction)
        {
            if (BaseNo % 2 != 0)
            {

                switch (direction)
                {
                    case "Left":
                    case "1":
                        int spcaceCounter = 0;
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            if (i <= BaseNo / 2)
                                Console.WriteLine(new string(' ', (BaseNo / 2) - i) + new string('*', i + 1));
                            else
                            {
                                spcaceCounter++;
                                Console.WriteLine(new String(' ', spcaceCounter) + new string('*', BaseNo - i));
                            }
                        }
                        break;

                    case "Up":
                    case "2":

                        for (int i = 0; i < BaseNo; i++)
                        {
                            int numOfSpaces = (BaseNo - i) / 2;
                            // numOfAstrisks = i
                            if (i % 2 != 0)
                                Console.WriteLine(new string(' ', numOfSpaces) + new string('*', i));
                        }
                        break;

                    case "Right":
                    case "3":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfAstrisks = i + 1;

                            if (i <= BaseNo / 2)
                                Console.WriteLine(new string('*', numOfAstrisks));
                            else
                                Console.WriteLine(new string('*', BaseNo - i));
                        }
                        break;

                    case "Down":
                    case "4":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfSpaces = i / 2;
                            int numOfAstrisks = BaseNo - i;
                            if (numOfAstrisks % 2 != 0)
                                Console.WriteLine(new string(' ', numOfSpaces) + new string('*', numOfAstrisks));
                        }
                        break;
                }
            }
            else
            {
                throw new Exception("Number must be odd");
            }

        }

        public string GetAstriskPyramidString(int BaseNo, string direction)
        {
            if (BaseNo % 2 != 0)
            {
                string pyramidChars = "";
                switch (direction)
                {
                    case "Left":
                    case "1":
                        int spcaceCounter = 0;
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            if (i <= BaseNo / 2)
                                pyramidChars += new string(' ', (BaseNo / 2) - i) + new string('*', i + 1) + "\n";
                            else
                            {
                                spcaceCounter++;
                                pyramidChars += new string(' ', spcaceCounter) + new string('*', BaseNo - i) + "\n";
                            }
                        }
                        return pyramidChars;

                    case "Up":
                    case "2":
                        for (int i = 0; i <= BaseNo; i++)
                        {
                            int numOfSpaces = (BaseNo - i) / 2 ;
                            // numOfAstrisks = i
                            if (i % 2 != 0)
                            {
                                pyramidChars += new string('*', i) + "\n";

                            }
                        }
                        return pyramidChars;

                    case "Right":
                    case "3":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfAstrisks = i + 1;

                            if (i <= BaseNo / 2)
                                pyramidChars += new string('*', numOfAstrisks) + "\n";
                            else
                                pyramidChars += new string('*', BaseNo - i) + "\n";
                        }
                        return pyramidChars;

                    case "Down":
                    case "4":
                        for (int i = 0; i < BaseNo + 1; i++)
                        {
                            int numOfSpaces = i / 2;
                            int numOfAstrisks = BaseNo - i;
                            if (numOfAstrisks % 2 != 0)
                                pyramidChars += new string('*', numOfAstrisks) + "\n";
                        }
                        return pyramidChars;

                     default:
                        return "Defult";
                }
            }
            else
            {
                throw new Exception("Number must be odd");
            }

        }
    }
}
