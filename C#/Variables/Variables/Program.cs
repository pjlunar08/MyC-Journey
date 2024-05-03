using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);
            
            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8d;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is " + double_num + " Float is " + float_num + " Decimal is " + decimal_num);

            

            string firstName, lastName, house;

            firstName = "Jon";
            lastName = " Snow";
            house = " Stark";


            Console.WriteLine("Hello " + firstName + lastName + " of House" + house);

            bool IsWorking;

            IsWorking = false;

            Console.WriteLine(IsWorking);

            int sum;
            sum = 0;

            int number1, number2;

            number1 = 5;
            number2 = 8;
            sum = number1 + number2;

            Console.WriteLine(sum);

    
        }
    }
}
