using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Thanga", "Rajan");

            (string fname, string lname, double age) = e;
            Console.WriteLine("First Name : " + fname);
            Console.WriteLine("Last Name : " + lname);
            Console.WriteLine("Age : " + age);
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }

        public Employee()
        {

        }
        public Employee(int id) => Id = id;
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;                
        }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }


        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname, out double age)
        {
            fname = FirstName;
            lname = LastName;
            age = Age;
        }


    }
}
