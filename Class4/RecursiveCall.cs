using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class RecursiveCall
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int number=Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("factorial of "+number+"="+factorial.ToString());
            Console.ReadKey();
        }
        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);//Recursive Call 
        }
    }
}
