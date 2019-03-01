using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLocalAndRefReturnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] locations = { "Germany" , "Singapore", "India", "London", "US" };
            Console.WriteLine(string.Join(" ", locations));
            ref string yourlocation = ref locations[2];
            ref string mylocation = ref GetLocations(locations, 1);

            mylocation = "Singapura";
            Console.WriteLine(mylocation);

            Console.WriteLine(string.Join(" ", locations));

            Console.ReadLine();
        }

        public static ref string GetLocations(string[] locations, int position)
        {
            return ref locations[position];
        }


    }
}
