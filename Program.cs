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
            int a, b, resultAdd, resultSub,resultMul;
            double sin;
            Console.WriteLine("vvedite pervoe 4islo");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vvedite vtoroe 4islo");
            b = Convert.ToInt32(Console.ReadLine());
            resultAdd = a + b;
            Console.WriteLine("symma =" + resultAdd);
            resultSub = a - b;
            Console.WriteLine("raznost` = " + resultSub);
            resultMul = a * b;
            Console.WriteLine("ymnozhenie =" + resultMul);
            sin = Math.Sin(a);
            Console.WriteLine($"sin(a) = { sin}");
            Console.ReadKey();
        }
    }
}
