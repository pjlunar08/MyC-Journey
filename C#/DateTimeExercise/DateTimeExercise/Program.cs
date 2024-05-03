using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate1 = string.Format("{0:dd-MM-yyyy HH:mm:ss}", myDate);
            string formattedDate2 = string.Format("{0:dddd} of the month {0:MMMM} year {0:yyyy}", myDate);
            string formattedDate3 = string.Format("Day {0:dddd} \n Month {0:MMMM} \n Year {0:yyyy}", myDate);

            Console.WriteLine(formattedDate1);
            Console.WriteLine(formattedDate2);
            Console.WriteLine(formattedDate3);
        }
    }
}
