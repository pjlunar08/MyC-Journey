using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCOnversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 3.9f;

            accountNo = serialNo.ToString();

            Console.WriteLine(accountNo);

            serialNo = Convert.ToInt32(anyNo); //Convert decimal to whole number with simplifying 
           

            Console.WriteLine(serialNo);



        }
    }
}
