using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class ArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Welcome");
            arrayList.Add(100);
            arrayList.Add(20.5);
            arrayList.Add("NestDigital");
            arrayList.Add(200);
            arrayList.Add(300);
            arrayList.Add(400);
            if(arrayList.Contains("NestDigital"))
            {
                Console.WriteLine("Yes,exists at index " + arrayList.IndexOf("NestDigital"));
            }
            else
            {
                Console.WriteLine("No,exists at index");
            }
            Console.ReadLine();
        }
    }
}
