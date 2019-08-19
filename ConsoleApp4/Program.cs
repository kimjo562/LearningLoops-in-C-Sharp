using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// While Loop Example
/*
namespace LearningLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while(count<5)                      // Will keep looping until condition is met (loop until count is no longer less than 5)
            {
                count++;                        // Adding increments of 1
                Console.WriteLine("The loop has run " + count + " times.");
            }
            Console.ReadKey();                  // 
        }
    }
}
*/

// For Loop Example
/*
namespace LearningLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int count = 0; count < 5; count++)                 // For Loop (Starts at 0 and counts 5 times)
            {
                Console.WriteLine("The loop has run " + count + " times.");
                if(count == 2)                                    
                {

                  // return;                                        // Using return inside a loop will exit the entire function, rather than just the loop.
                  // break;                                         // This causes for it to break out of the loop early

                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();                                      // Similar to cls("pause") in c++
        }
    }
}
*/

namespace LearningLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 120; count > 15; count -= 3)               // For Loop (Starts at 
            {
                Console.WriteLine("The loop has run " + count + " times.");
                if (count == 90)
                {

                    // return;                                        // Using return inside a loop will exit the entire function, rather than just the loop.
                    // break;                                         // This causes for it to break out of the loop early

                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();                                      // Similar to cls("pause") in c++
        }
    }
}