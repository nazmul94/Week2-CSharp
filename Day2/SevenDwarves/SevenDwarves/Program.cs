using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenDwarves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + "Your dinner is ready");
            }

            Console.WriteLine("=============");

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine(dwarf + " Your drink is ready.");
            }

            Console.WriteLine("==============");


            string[] orders = new String[sevenDwarves.Length];

            foreach (string name in sevenDwarves)
            {
                restart:
                Console.WriteLine("What do you want " + name + " ?");
                string order = Console.ReadLine();
                if (order != "")
                {
                    Console.WriteLine(name + ", your " + order + " is ready. Enjoy your meal.");
                }
                else
                {
                    goto restart;
                }
            }
        }
    }
}
