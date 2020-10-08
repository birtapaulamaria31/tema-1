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
            n= int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Log(n, 2) * 1.5);
            Console.ReadKey();
        }
    }
}
