using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **Employee Wage Computation**");

            Random obj = new Random();
            int check = obj.Next(0,2);

            if (check==0 ) 
            {
                Console.WriteLine("Employee is Absent ");
            
            }
            else
            {
                Console.WriteLine("Employee is Present ");

            }

        }
    }
}
