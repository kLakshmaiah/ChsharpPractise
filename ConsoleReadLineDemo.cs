using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsharpPractise
{
    internal class ConsoleReadLineDemo
    {
        public static void Main()
        {
            //Contact Details
            //Console.ReadLine for taking the inputs

            Console.Write("Enter Name:- ");
            string name= Console.ReadLine();
            correctMobilenumber://goto statement.
            Console.Write("Enter MobileNumber:- ");
            string MobileNumber = Console.ReadLine();
            if(MobileNumber.Length!= 10)
            {
                Console.WriteLine("Please Enter 10 digits MobileNumber");
                goto correctMobilenumber;
            }
            Console.WriteLine("Enter Salary");
            //double salary = Convert.ToDouble(Console.ReadLine()); confirm ga makanik numbers vastunnapudu.
            //double salary = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name is {name.ToUpper()}");
            Console.WriteLine($"MobileNumber is {MobileNumber}");
            Console.WriteLine("Salary is {0}", salary);
            Console.ReadLine();
        }
    }
}
