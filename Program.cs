using System;

namespace Exercise9
{
    class Program
    {
        /*Write a console-based application that sums the integers from 1 to 50.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Input a number between 1 and 50! \nObs: The number has to be interger");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a second between 1 and 50!");
            int b = Convert.ToInt32(Console.ReadLine());

            

            while ((a < 1) || (b < 1) || (a > 50) || (b > 50))
            {

                Console.WriteLine("Error!");
                Console.WriteLine("\nInput a number between 1 and 50! \nObs: The number has to be interger");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nInput a second between 1 and 50!");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
            }
                int sum = a + b;
                Console.WriteLine("The sum between " + a + " and " + b + " is " + sum);
            
        }
    }
}
