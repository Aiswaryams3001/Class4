using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    public class Customer
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
    internal class AccessEg
    {
        private static void Main()
        {
            Customer c=new Customer();
            c.Id = 101;
            Console.WriteLine(c.Id);
            Console.ReadKey();
        }
    }
}
