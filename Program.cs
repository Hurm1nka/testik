using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultAdd;
            Console.WriteLine("vvedite pervoe 4islo");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vvedite vtoroe 4islo");
            b = Convert.ToInt32(Console.ReadLine());
            resultAdd = a + b;
            Console.WriteLine("symma =" + resultAdd);
            Console.ReadKey();
        }
    }
}
