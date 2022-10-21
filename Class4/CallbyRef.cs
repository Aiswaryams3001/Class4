using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class CallbyRef
    {
        public void show(int a)
        {
            a *= a;//Manipulating value
            Console.WriteLine("Value inside the show fuction"+a);
            //No return statement
        }
        static void Main(string[] args)
        {
            int a = 50;
            CallbyRef p=new CallbyRef();
            Console.WriteLine("Value before calling the function" + a);
            p.show(a);
            Console.WriteLine("Value after calling the function" + a);
            Console.ReadKey();
        }
    }
}
