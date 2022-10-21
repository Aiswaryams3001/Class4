using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class4
{
    internal class OptionalEg
    {
        public static void Main(string[] args)
        {
            OptionalEg obj=new OptionalEg();
            obj.add(12, 12);
            obj.add(10);
            Console.ReadKey();
        }
        public void add(int a,int b=10)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
