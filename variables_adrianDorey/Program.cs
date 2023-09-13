using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_adrianDorey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine("____________");
            Console.WriteLine();

            //types:
            // integer = whole numbers  (-3,-2,-1,0,1,2,3)


            // declaring score variable to be an "integer" type
            int score;

            //initializing score
            score = 0;

            //hud
            Console.WriteLine(score);


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}