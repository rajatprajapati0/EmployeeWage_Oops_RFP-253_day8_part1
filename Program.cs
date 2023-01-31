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
            int halfDayhour = 4;
            int perHourWage = 20;

            int check = obj.Next(0,3);

            if (check==0 ) 
            {

                Console.WriteLine("Employee is Absent ");
            
            }
            else if (check==1)
            {
                dailyWadge = perHourWage * halfDayhour;
                Console.WriteLine("Employee is Present for half day his Daily wage  "+dailyWadge );

            }  else
            {
                dailyWadge = perHourWage * fullDayhour;
                Console.WriteLine("Employee is Present for full day his Daily wage  " + dailyWadge);

            }

        }
    }
}
