using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var result = Calculate(3, 4);
            Console.WriteLine(result.sum);
            Console.WriteLine(result.product);
            Console.ReadLine();
        }
        public static (int sum,int product) Calculate(int a, int b)
        {
            int sum = a + b;
            int product = a * b;
            return (sum, product);

        }
    }
}
