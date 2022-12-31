using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class MonthWage
    {
        public  void Cal_Monthwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int wagePerHour = 20;
            int workingHours = 8;
            int Totalwork = 0;
            int Employeee = 1;
            int MonthDays = 20;

            int Monthwork = 0;
            for (int i = 0; i < MonthDays; i++)
            {
                int atten = EmployeeAttendance.checkatt(Employeee);

                if (atten == 1)
                {
                    Totalwork = wagePerHour * workingHours;
                    Console.WriteLine("total work in day: " + Totalwork);
                    Console.WriteLine();

                }
                else if (atten == 2)
                {
                    Totalwork = wagePerHour * (workingHours / 2);
                    Console.WriteLine("total Part time work in day: " + Totalwork);
                    Console.WriteLine();

                }
                else
                {
                    Totalwork = 0;
                    Console.WriteLine("total work : " + Totalwork);
                    Console.WriteLine();
                }
                Monthwork += Totalwork;
            }
            Console.WriteLine("TOTAL MONTH WORK: " + Monthwork);
        }
    }
}
