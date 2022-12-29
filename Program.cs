using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, i, flag, temp;
            // take an int as an input from user to start counting from
            Console.WriteLine("Enter The Number To Start Counting From");
            n1 = int.Parse(Console.ReadLine());

            // take an int as an input from user to stop counting from
            Console.WriteLine("Enter The Number To Stop Counting From");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            // print statemet(prime number betweeen n1 and n2)
            Console.WriteLine("prime Number Between"+n1+" and"+n2);

            while (n1 < n2)
            {


                flag = 0;
                for (i = 2; i <= n1 / 2; i++)
                {
                    if (n1 % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                
                    Console.WriteLine("\t"+n1);
                    n1++;
                
            }
            

        }
    }
}
