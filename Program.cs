using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **Employee Wage Computation** \n");
            Random obj = new Random();

            int dailyWadge = 0;
            int fullDayhour = 8;
            int perHourWage = 20;

            int check = obj.Next(0,2);

            if (check==0 ) 
            {

                Console.WriteLine("Employee is Absent ");
            
            }
            else
            {
                dailyWadge = perHourWage * fullDayhour;
                Console.WriteLine("Employee is Present his Daily wage  "+dailyWadge );

            }

        }
    }
}
