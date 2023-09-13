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
            int score;   // int score=0 is a shortcut
            int enemyValue;
            string realName;
            string gamerTag;
            float percentile;

            //initializing score
            score = 0;
            enemyValue = 250;
            realName = "Adrian Dorey";
            gamerTag = "adorey91";
            percentile = 85.543f;

            //pretend gameplay
            score = score + enemyValue; // "=" gets the value of
            // score += enemyValue is the same as above
            //hud 
            Console.WriteLine(realName +" (" + gamerTag+")");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: "+percentile);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}