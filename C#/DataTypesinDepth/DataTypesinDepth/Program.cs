using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesinDepth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            x = int.MaxValue;

            Console.WriteLine(x);

            uint y = 2147483648;

            y = uint.MinValue;

            Console.WriteLine(y);

            Console.WriteLine(typeof(decimal).IsPrimitive);

        }
    }
}
