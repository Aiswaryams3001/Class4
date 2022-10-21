using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class FunctionWithNamedArguments
    {
        public string GetFullName(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
        public static void Main(string[] args)
        {
            FunctionWithNamedArguments n = new FunctionWithNamedArguments();
            string fullName1 = n.GetFullName("Jolsna", "Jose"); //Without Named Arguments
            string fullName2 = n.GetFullName(firstName: "Jolsna", lastName: "Jolsna"); // Named Arguments
            string fullName3 = n.GetFullName(lastName: "Jolsna", firstName: "Jose");    // Changing Order
            Console.WriteLine(fullName1);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);
            Console.ReadKey();
        }
    }
}
