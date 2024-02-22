using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            HeartRates heartRate = new HeartRates();
            Console.Write("Please enter your first name: ");
            heartRate.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            heartRate.LastName = Console.ReadLine();
            Console.Write("Please enter your birth year: ");
            heartRate.BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            heartRate.CurrentYear = int.Parse(Console.ReadLine());

            heartRate.displayPatientRecord();

        }
    }
}
