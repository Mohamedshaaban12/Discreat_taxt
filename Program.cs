using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // take as int as an from to start counting from
            Console.WriteLine("Enter The Number To Start Counting from:");
            int Number1 = int.Parse(Console.ReadLine());

            // take as int as an from to stop counting from
            Console.WriteLine("Enter The Number To Stop Counting from:");
            int Number2 = int.Parse(Console.ReadLine());

            //an outer loop that start from number1 to number2
            for(int c = Number1; c <= Number2; c++)
            {
                //anew variable that sum up the factors of the number(which is c) that the outer loop stoped at (the number itself wont be added up)
                int sum = 0;
                /* an inner for loop that start counting from 1 to bellow the number that c stopped at by 1
                 so each time c increases the inner loop start all over again*/
                for(int d = 1; d < c; d++)
                {
                    //if the number is disisible by another number, add that number to sum
                    if (c % d == 0)
                    {
                        sum += d;
                    }
                    else
                    {
                        continue;
                }   }
                    //if sum equal to c, then the number is perfect
                    if (sum == c)
                    {
                        Console.WriteLine(c);
                    }
                        
                
            }


        }
    }
}
