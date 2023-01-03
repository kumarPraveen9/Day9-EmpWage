using Employee;

namespace Emloyee
{
    class Program
    {
        public static void Main(string[] args)
        {
            employeeBuilderWage obj =new employeeBuilderWage("deloitte",20,20,80);
            obj.Cal_Wage();
            Console.WriteLine(obj.toString());
            
            employeeBuilderWage obj1 = new employeeBuilderWage("adobe",25,10,90);
            obj1.Cal_Wage();
            Console.WriteLine(obj1.toString());

            
        }
    }
}
