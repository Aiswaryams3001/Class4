using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("A");
            arrayList.Add("B");
            arrayList.Add("C");
            arrayList.Add("D");
            arrayList.Reverse();
            foreach(object obj in arrayList)
            {
                Console.WriteLine("{0}",obj);
            }
            Console.ReadLine();
        }
    }
}
