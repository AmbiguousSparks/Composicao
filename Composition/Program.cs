using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.Entities;
using System.Globalization;
using Composition.Entities.Enums;
namespace Composition
{
    class Program
    {
        static void Main ( string[] args )
        {

            Console.Write("Enter department's name: ");

            string department = Console.ReadLine();

            Department dp = new Department { Name = department };

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");

            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");

            string level = Console.ReadLine();

            WorkerLevel wl = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);

            Console.Write("Base salary: ");

            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("How many contracts do this worker? ");

            int numContracts = int.Parse(Console.ReadLine());

            Worker worker = new Worker { Name = name, Level = wl, Department = dp, BaseSalary = baseSalary };

            for (int i = 0; i < numContracts; i++)
            {

                Console.WriteLine("Enter #" + (i + 1) + " contract data:");

                Console.Write("Date (DD/MM/YYYY): ");

                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");

                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                Console.Write("Duration: ");

                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract { Date = date, ValuePerHour = valuePerHour, Hours = duration };

                worker.AddContract(contract);

            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string[] dateIncome = Console.ReadLine().Split('/');

            Console.WriteLine("\n" + worker + "\nIncome for " + dateIncome[0] + "/" + dateIncome[1] + ": " +
                worker.Income(int.Parse(dateIncome[1]), int.Parse(dateIncome[0])));

        }
    }
}
