using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = Add(a, b);
            Console.WriteLine("Result " + c);
            Console.ReadLine();

            int Add(int a1, int b1)
            {
                int c1 = a1 + b1 + a;
                return c1;
            }
        }

       
    }
}
