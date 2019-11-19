using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge11
{
    class Program
    {
        static void Main(string[] args)
        {
            string gate, input1, input2;
            bool quit = false;
            do
            {
                Console.WriteLine("Enter logic gate (OR, AND, XOR) or Q to quit");
                gate = Console.ReadLine().Trim().ToUpper();
                if (gate == "Q")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Enter first input (0 or 1) to quit");
                    input1 = Console.ReadLine().Trim().ToUpper();
                    Console.WriteLine("Enter second input (0 or 1) to quit");
                    input2 = Console.ReadLine().Trim().ToUpper();

                    switch (gate)
                    {
                        case "OR":
                            Console.WriteLine("Output is {0}",Or(input1, input2));
                            break;
                        case "AND":
                            //todo
                            break;
                        case "XOR":
                            //todo
                            break;
                        default:
                            Console.WriteLine("Unexpected input: {0}", gate);
                            break;
                    }

                    Console.WriteLine();
                }
            } while (!quit); //(!quit) means the same as (quit!= true)
        }

        private static string Or(string input1, string input2)
        {
            if ((input1 == "1") || (input2 == "1"))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
