using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class ArrayListEg
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Welcome");
            arrayList.Add(100);
            arrayList.Add(20.5);
            arrayList.Add("NestDigital");
            arrayList.Insert(0, "Hi");
            arrayList.Insert(1, 50);
            ArrayListEg arrayList2 = new ArrayListEg();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
