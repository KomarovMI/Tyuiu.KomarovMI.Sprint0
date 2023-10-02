using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KomarovMI.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Adition(5, 11));
            Console.WriteLine(DataService.Subtraction(80, 24));
            Console.WriteLine(DataService.Multiplication(5, 10));
            Console.WriteLine(DataService.Division(6, 3));
            Console.ReadKey();
        }
    }
}
