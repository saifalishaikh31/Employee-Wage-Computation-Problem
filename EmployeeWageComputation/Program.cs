using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            WageComputation dMart = new WageComputation();
            dMart.empWageBuilderObject("DMart", 20, 2, 10);
            WageComputation reliance = new WageComputation();
            reliance.empWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.ReadLine();
        }
    }
}
