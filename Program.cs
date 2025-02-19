using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using practice.Properties;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.color.ToUpper());
        }
    }
}
