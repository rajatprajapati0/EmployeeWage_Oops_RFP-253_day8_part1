using System;


namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            logic obj = new logic();
            int totalWage=obj.EmployeeWage();
            int absent = obj.absent;
           int totalpresent=obj.totalpresent;
            int totalHour = obj.totalHour;
            int halfDayPresent=obj.halfDayPresent;

            int fullDayPresent = obj.fullDayPresent;


            Console.WriteLine("Employee absent in a month - "+absent );
            Console.WriteLine("Employee half day present in a month  - " + halfDayPresent);
            Console.WriteLine("Employee full day present in a month  - " + fullDayPresent);
            Console.WriteLine("Employee total wage  - " + totalWage);
            Console.WriteLine("Employee present day in a month  - " + totalpresent);
            Console.WriteLine("Employe worked hour in a month - " + totalHour);
            Console.ReadLine();
            
        }
       

    }
}
