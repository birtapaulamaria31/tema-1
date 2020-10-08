using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t;
            Console.WriteLine("Introduceti un numar natural n");
            n= int.Parse(Console.ReadLine());
           
            Console.WriteLine("Numarul de ani in care puterea de calcul creste de n ori este: {0}",Math.Log(n, 2) * 1.5);
            Console.ReadKey();
        }
    }
}
