using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1P2
{
    internal class HealthRates
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int heightInInches;
        private int weightInPound;
        private int currentYear;

        public HealthRates() { }
        public HealthRates(string firstName, string lastName, int birthYear, int heightInInches, int weightInPound, int currentYear)
        {
           FirstName = firstName;
           LastName = lastName;
           BirthYear = birthYear;
           HeightInInches = heightInInches;
           WeightInPounds = weightInPound;
           CurrentYear = currentYear;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return heightInInches;
            }
            set
            {
                heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return weightInPound;
            }

            set
            {
                weightInPound = value;
            }
        }

        public int CalcAge
        {
            get
            {
                return currentYear - birthYear;
            }
        }

        public int CalcMaxHR
        {
            get
            {
                return 220 - CalcAge;
            }
        }

        public double MinTargetHR
        {
            get
            {
                return CalcMaxHR * 0.5;
            }
        }

        public double MaxTargetHR
        {
            get
            {
                return CalcMaxHR * 0.85;
            }
        }

        public double CalcBMI()
        {
            double bmi =  weightInPound * 703 / (Math.Pow(heightInInches, 2));
            return Math.Round(bmi, 2);
        }


        public String BMI_Test()
        {
            double BMI = CalcBMI();

            if (BMI < 18.5)
            {
                return "Underweight";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                return "Normal";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }


        public void DisplayHealthRecord()
        {
            drawLine();
            Console.WriteLine($"|  {"PATIENT HEALTH RECORDS",47} {"|",31}");
            drawLine();
            Console.WriteLine($"| {"Patient Name",-25} | {lastName + ", " + firstName,-50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Birth Year",-25} | {birthYear,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Age ",-25} | {CalcAge,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Height",-25} | {heightInInches,50} |");
            drawLine();
            Console.WriteLine($"| {"Patient Weight",-25} | {weightInPound,50} |");
            drawLine();
            Console.WriteLine($"| {"Maximum Heart Rate ",-25} | {CalcMaxHR,50} |");
            drawLine();
            Console.WriteLine($"| {"Target Heart Rate Range",-25} | {MinTargetHR + " - " + MaxTargetHR,50} |");
            drawLine();
            Console.WriteLine($"| {"BMI Numeric Values",-25} | {CalcBMI(),50} |");
            drawLine();
            Console.WriteLine($"| {"BMI Text Value",-25} | {BMI_Test(),-50} |");
            drawLine();
        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)
                Console.Write("-");
            Console.WriteLine("|");

        }
    }
}
