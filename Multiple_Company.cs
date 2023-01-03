using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class RefactoringCode
    {
        public void Cal_Wage(string Company,int wagePerHour, int maxdays,int maxhours)
        {
            Console.WriteLine("\n Program for Calculating {0} Employee Wage !!\n",Company);

            int workingHours=8 ;
           
            int emphours = 0;
            int days = 1;
            int Totalwork = 0;
            int Monthwork = 0;
          

            while ((emphours <= maxhours) && (days <= maxdays))
            {
                Random random = new Random();
                int atten = random.Next(3);
               

                if (atten == 1)
                {
                    Totalwork = wagePerHour * 8;
                    workingHours = 8;
                }
                else if (atten == 2)
                {
                    Totalwork = wagePerHour * 4;
                    workingHours = 4;
                }
                else
                {
                    Totalwork = 0;
                    workingHours = 0;
                }
                emphours += workingHours;
                Monthwork += Totalwork;
                if (emphours <= maxhours)
                Console.WriteLine("day::{0} employee_hour::{1} empwage : {2}", days, emphours,Totalwork);
                days++;
            }
            Console.WriteLine("TOTAL MONTH WORK: " + Monthwork);
            
        }
    }
}
