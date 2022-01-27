using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int EMP_PRESENT = 0, EMP_ABSENT = 1;
        public void EmpAttendace()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck==EMP_PRESENT)
	        {
                Console.WriteLine("Employee is present");
	        }
            if (empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
