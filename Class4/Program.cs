using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Program
    {
        public void Display()
        {
            Console.WriteLine("Hello...");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Display();
            Console.ReadKey();
        }
    }
}
