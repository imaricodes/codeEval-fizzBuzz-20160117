using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeEval_fizzBuzz_20160117
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 2; //first factor
            int y = 3; //second factor
            int countTo = 12; //this will later be parsed from the string of three numbers given..what number to count up to


            for (int i = 1; i <= countTo; i++)
            {
                //setting condition based on value of i
                bool condition1 = (i % x == 0 && i % y != 0);  //true when x is divibisble by the seriesCount var and y is not
                bool condition2 = (i % y == 0 && i % x != 0);  //true when y is divisibe by the seriesCount var and x is not
                bool condition3 = (i % y == 0 && i % x == 0);  //true when both x and y are divisibe by the seriesCount
                
                //testing conditions and printing corresponding result
                if (condition1)
                    Console.Write("F" + " ");
                else if (condition2)
                    Console.Write("B" + " ");
                else if (condition3)
                    Console.Write("FB" + " ");
                else
                    Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
