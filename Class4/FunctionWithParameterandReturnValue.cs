using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class FunctionWithParameterandReturnValue
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            FunctionWithParameterandReturnValue s = new FunctionWithParameterandReturnValue();
            int c = s.Add(10, 12);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
