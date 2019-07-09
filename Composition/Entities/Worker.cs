using Composition.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Entities
{
    class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public List<HourContract> Contracts { get; set; }

        public Department Department { get; set; }

        public Worker ()
        {
            Contracts = new List<HourContract>();
        }

        public void AddContract ( HourContract contract )
        {
            Contracts.Add(contract);
        }

        public void AddContract ( List<HourContract> contracts )
        {
            Contracts = contracts;
        }

        public void RemoveContract ( HourContract contract )
        {
            Contracts.Remove(contract);
        }

        public double Income ( int year, int month )
        {

            double totalSalary = BaseSalary;

            foreach (HourContract contract in Contracts.FindAll(x => x.Date.Year == year && x.Date.Month == month))
            {
                totalSalary += contract.TotalValue();
            }

            return totalSalary;

        }

        public override string ToString ()
        {
            return "Name: "
                + Name
                + "\nDepartment: "
                + Department.Name;
        }
    }
}
