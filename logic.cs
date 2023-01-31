using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage
{
    internal class logic
    {
     
        static int Day = 20;
        public int totalHour = 0;
        public int fullDayPresent = 0;
        public int halfDayPresent = 0;
        public int absent = 0;
        static int dailyWadge = 0;
        static int fullDayhour = 8;
        static int halfDayhour = 4;
        static int perHourWage = 20;
        public int totalpresent = 0;

        

        public int EmployeeWage()

        {
            Console.WriteLine(" **Employee Wage Computation** \n");
            Random obj = new Random();
            
            int totalWage = 0;

            for (int i = 0; i < Day && totalHour <= 100; i++)

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

                totalpresent = fullDayPresent + halfDayPresent;
                
            }

            return totalWage ;
           
        }

    }
}