namespace EmplyOops
{
    public class EmployeeAttendance
    {
        public static int checkatt(int Employeee)
        {
         
            Random random = new Random();
            int check = random.Next(2);
            if (Employeee == check)
            {
                Console.WriteLine("\n employee is present");


            }
            else
            {
                Console.WriteLine("\n employee is absent");
            }
            return check;
        }
        
    }
}
