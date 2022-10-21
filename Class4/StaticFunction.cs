using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class StaticFunction
    {
        static void Display(string name)
        {
            Console.WriteLine("Hello....." + name);
        }
        static void Main(string[] args)
        {
            Display("Anju");
            Display("Anjali");
            Console.ReadKey();
        }
    }
}
