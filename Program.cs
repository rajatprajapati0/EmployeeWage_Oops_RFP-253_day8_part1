using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **Employee Wage Computation** \n");
            Random obj = new Random();
            int Day = 20;
            int  totalHour= 0;
            int fullDayPresent = 0;
            int halfDayPresent = 0;
            int absent = 0;
            int dailyWadge = 0;
            int fullDayhour = 8;
            int halfDayhour = 4;
            int perHourWage = 20;
            int totalWage = 0;

         for (int i=0; i<Day && totalHour<=100; i++ )

         {
                int check = obj.Next(0, 3);

               
                
                    switch (check)
                    {
                        case 0:

                            absent++;
                            break;

                        case 1:
                            dailyWadge = perHourWage * halfDayhour;
                            totalWage += dailyWadge;
                            halfDayPresent++;
                            totalHour = totalHour + halfDayhour;
                            break;

                        case 2:
                            dailyWadge = perHourWage * fullDayhour;
                            totalWage += dailyWadge;
                            totalHour = totalHour + fullDayhour;
                            fullDayPresent++;

                            break;
                    }
         }

            Console.WriteLine("Employee absent in a month - "+absent );
            Console.WriteLine("Employee half day present in a month  - " + halfDayPresent);
            Console.WriteLine("Employee full day present in a month  - " + fullDayPresent);
            Console.WriteLine("Employee total wage  - " + totalWage);
            Console.WriteLine("Employee present in a month  - " + (halfDayPresent+fullDayPresent));
            Console.WriteLine("Employe worked hour in a month - " + totalHour);
            Console.ReadLine();


        }
       

    }
}
