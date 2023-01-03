using Employee;

namespace Emloyee
{
    class Program
    {
        public static void Main(string[] args)
        {
             RefactoringCode obj=new RefactoringCode();
            obj.Cal_Wage("Deloitte",20,15,80);
            obj.Cal_Wage("Adobe", 25, 10, 60);

            
        }
    }
}
