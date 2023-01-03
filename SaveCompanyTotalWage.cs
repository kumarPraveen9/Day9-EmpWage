using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class employeeBuilderWage
    {

        private string Company;
        private int wagePerHour;
        private int maxdays;
        private int maxhours;
        private int Monthwork;

        public employeeBuilderWage(string Company, int wagePerHour, int maxdays, int maxhours)
        {
            this.Company = Company;
            this.wagePerHour = wagePerHour;
            this.maxdays = maxdays;
            this.maxhours = maxhours;
        }



        public void Cal_Wage()
        {
            Console.WriteLine("\n Program for Calculating {0} Employee Wage !!\n", Company);

            int workingHours = 8;

            int emphours = 0;
            int days = 1;
            int Totalwork = 0;
           // int Monthwork = 0;


            while ((emphours <= this.maxhours) && (days <= this.maxdays))
            {
                Random random = new Random();
                int atten = random.Next(3);


                if (atten == 1)
                {
                    Totalwork = this.wagePerHour * 8;
                    workingHours = 8;
                }
                else if (atten == 2)
                {
                    Totalwork = this.wagePerHour * 4;
                    workingHours = 4;
                }
                else
                {
                    Totalwork = 0;
                    workingHours = 0;
                }
                emphours += workingHours;

                if (emphours <= maxhours)
                {
                    this.Monthwork += Totalwork;
                    Console.WriteLine("day::{0} employee_hour::{1} empwage : {2}", days, emphours, Totalwork);
                }
                days++;
            }
            Console.WriteLine("TOTAL MONTH WORK: " + this.Monthwork);
        }

        public string toString()
            {
            return "the company : "+this.Company+" total work is :  "+this.Monthwork;
            }
    }
}
