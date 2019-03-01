using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLiteralAndDigitSeparatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryDemo();
        }

        public static void BinaryDemo()
        {
            int a = 0b100;
            Console.WriteLine(a);
            Console.ReadLine();
        }
        public static void DigitSeparatorDemo()
        {
            int Id_Internal = 1_00_00_00_000;
            Console.WriteLine(Id_Internal);
            Console.ReadLine();
        }
    }
}
