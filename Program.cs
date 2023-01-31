using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **Employee Wage Computation** \n");
            Random obj = new Random();
            int Day = 0;
            int  totalday = 0;
            int fullDayPresent = 0;
            int halfDayPresent = 0;
            int absent = 0;
            int dailyWadge = 0;
            int fullDayhour = 8;
            int halfDayhour = 4;
            int perHourWage = 20;
            int totalWage = 0;

         while(Day!=20 && totalday!=30)

            {
                int check = obj.Next(0, 3);

                switch (check)
                {
                    case 0:
                        totalday++;
                        absent++;
                        break;

                    case 1:
                        dailyWadge = perHourWage * halfDayhour;
                        totalWage += dailyWadge;
                        halfDayPresent++;
                        Day++;
                        totalday++;
                        break;

                    case 2:
                        dailyWadge = perHourWage * fullDayhour;
                        totalWage += dailyWadge;

                        fullDayPresent++;
                        Day++;
                        totalday++;
                        break;
                }


            }

            Console.WriteLine("Employee absent in a month - "+absent );
            Console.WriteLine("Employee half day present in 0a month  - " + halfDayPresent);
            Console.WriteLine("Employee full day present in a month  - " + fullDayPresent);
            Console.WriteLine("Employee total wage  - " + totalWage);
            Console.WriteLine("Employee present in a month  - " + (halfDayPresent+fullDayPresent));




        }


    }
}
