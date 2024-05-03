using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = string.Format("Date is {0:yyyy/MM/dd/ HH:mm:ss tt}", myDate);
            Console.WriteLine(formattedDate);
          
        }
    }
}
