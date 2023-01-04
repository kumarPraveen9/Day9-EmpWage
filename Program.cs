using EmplyOops;

namespace EmplyOops
{
    class Program
    {
        public static void Main(string[] args)
        {
            employeeWageCompanyArray obj =new employeeWageCompanyArray();
          
           
            obj.addCompanies("deloitte", 20, 15, 90);

            obj.addCompanies("adobe", 25, 10, 80);
            obj.computeWage();




           
        }
    }
}
