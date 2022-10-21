using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class ArrayList4
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Z");
            arrayList.Add("H");
            arrayList.Add("C");
            arrayList.Add("G");
            arrayList.Clear();
            foreach (object obj1 in arrayList)
            {
                Console.WriteLine("{0}", obj1);
            }

            Console.ReadLine();
        }
    }
}

