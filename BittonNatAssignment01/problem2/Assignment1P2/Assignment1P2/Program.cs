
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1P2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {

        static void Main(string[] args)
        {
            HealthRates healthRecord = new HealthRates();
            Console.Write("Please enter your first name: ");
            healthRecord.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            healthRecord.LastName = Console.ReadLine();
            Console.Write("Please enter your birth year: ");
            healthRecord.BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            healthRecord.CurrentYear = int.Parse(Console.ReadLine());
            Console.Write("Please enter your height in Inches: ");
            healthRecord.HeightInInches = int.Parse(Console.ReadLine());
            Console.Write("Please enter your weight in Pounds: ");
            healthRecord.WeightInPounds = int.Parse(Console.ReadLine());

            healthRecord.DisplayHealthRecord();
        }
    }
}

