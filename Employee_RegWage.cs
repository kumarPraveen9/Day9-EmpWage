using EmplyOops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class EmployeeCal_RegWage
    {
        public  void Cal_Rwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int wagePerHour = 20;
            int workingHours = 8;
            int Totalwork = 0;
            int Employeee = 1;
            int atten = EmployeeAttendance.checkatt(Employeee);

            if (atten == 1)
            {
                //Console.WriteLine("\n employee is present");
                Totalwork = wagePerHour * workingHours;
                Console.WriteLine("total work : " + Totalwork);
            }
            else
            {
                //Console.WriteLine("\n employee is absent");
                Console.WriteLine("total work : " + Totalwork);
            }
        }
    }
}
