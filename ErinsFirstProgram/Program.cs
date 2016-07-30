using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErinsFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year of Birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month of Birth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day of Birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            DateTime birthDate = new DateTime(year, month, day);

            CalculateDaysSinceBirth(birthDate);
            
        }
       static void CalculateDaysSinceBirth(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            TimeSpan daysAlive = now - birthDate;
            Console.WriteLine(daysAlive.Days);
        }
    }
}
