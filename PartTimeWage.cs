using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class EmployeeCal_PartTimeWage
    {
        public  void Cal_Pwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int wagePerHour = 20;
            int workingHours = 8;
            int Totalwork = 0;
            int Employeee = 1;
            int atten = EmployeeAttendance.checkatt(Employeee);

            if (atten == 1)
            {
                
                Totalwork = wagePerHour * workingHours;
                Console.WriteLine("total work : " + Totalwork);
            }
            else if (atten == 2)
            {
                Totalwork = wagePerHour * (workingHours / 2);
                Console.WriteLine("total work : " + Totalwork);
            }
            else
            {
              
                Console.WriteLine("total work : " + Totalwork);
            }
        }
    }
}
