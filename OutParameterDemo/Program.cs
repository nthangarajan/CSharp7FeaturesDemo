using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Calculate(10, 20, out int SumValue, out int _);
            Console.WriteLine(SumValue);
            //Console.WriteLine(ProductValue);
            Console.ReadLine();

        }
        public static void Calculate(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;

        }
    }
}
