using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyOops
{
    public class employeeWageCompanyArray
    {

        private UsePojo[] CompanywageArray;
        private int noOfCompany = 0;
        public employeeWageCompanyArray()
        {
            this.CompanywageArray = new UsePojo[5]; 
        }
        public void addCompanies(string Company, int wagePerHour, int maxdays, int maxhours)
        {
            CompanywageArray[noOfCompany] = new UsePojo(Company,wagePerHour,maxdays,maxhours);
            noOfCompany++;
        }

        public void computeWage()
        {
            for (int i=0;i<noOfCompany;i++)
            {
                CompanywageArray[i].setEmpWage(computeWage(CompanywageArray[i]));
                Console.WriteLine(CompanywageArray[i].toString());

            }
        }


        private int computeWage(UsePojo usePojo)
        {
            Console.WriteLine("\n Program for Calculating {0} Employee Wage !!\n", usePojo.Company);

            int workingHours = 8;

            int emphours = 0;
            int days = 1;
            int Totalwork = 0;
           // int Monthwork = 0;


            while ((emphours <= usePojo.maxhours) && (days <= usePojo.maxdays))
            {
                Random random = new Random();
                int atten = random.Next(3);


                if (atten == 1)
                {
                    Totalwork = usePojo.wagePerHour * 8;
                    workingHours = 8;
                }
                else if (atten == 2)
                {
                    Totalwork = usePojo.wagePerHour * 4;
                    workingHours = 4;
                }
                else
                {
                    Totalwork = 0;
                    workingHours = 0;
                }
                emphours += workingHours;

                if (emphours <= usePojo.maxhours)
                {
                    usePojo.Monthwork += Totalwork;
                    Console.WriteLine("day::{0} employee_hour::{1} empwage : {2}", days, emphours, Totalwork);
                }
                days++;
            }
            return usePojo.Monthwork;
        }

       
    }
}
