using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class SwitchCase
    {
        public void Cal_Switchwage()
        {
            Console.WriteLine("Program for Calculating Employee Wage using Switch case!!");

            int wagePerHour = 20;
            int workingHours = 8;
            int Totalwork = 0;
            int Employeee = 1;
            int atten = EmployeeAttendance.checkatt(Employeee);

            switch (atten)
            {

                case 1:
                    //Console.WriteLine("\n employee is present");
                    Totalwork = wagePerHour * workingHours;
                    Console.WriteLine("total work : " + Totalwork);
                    break;
                case 2:

                    Totalwork = wagePerHour * (workingHours / 2);
                    Console.WriteLine("total work : " + Totalwork);
                    break;

                default:
                    //Console.WriteLine("\n employee is absent");
                    Console.WriteLine("total work : " + Totalwork);
                    break;
            }
        }
    }
}
