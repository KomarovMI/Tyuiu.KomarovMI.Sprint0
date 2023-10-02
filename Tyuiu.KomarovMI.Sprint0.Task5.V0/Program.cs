using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KomarovMI.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A+B=" +DataService.Adition(5, 11));
            Console.WriteLine("A-B=" +DataService.Subtraction(80, 24));
            Console.WriteLine("A*B=" +DataService.Multiplication(5, 10));
            Console.WriteLine("A/B=" +DataService.Division(6, 0));
            Console.ReadKey();
        }
    }
}
