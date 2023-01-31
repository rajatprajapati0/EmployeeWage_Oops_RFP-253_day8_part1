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

            switch (check ) 
            {
                case 0 :
                         Console.WriteLine("Employee is Absent ");
                    break;

                case 1 :
                          dailyWadge = perHourWage * halfDayhour;
                          Console.WriteLine("Employee is Present for half day his Daily wage  "+dailyWadge );
                    break;

                case 2:
                          dailyWadge = perHourWage * fullDayhour;
                          Console.WriteLine("Employee is Present for full day his Daily wage  " + dailyWadge);
                    break;
            }

        }
    }
}
