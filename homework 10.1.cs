using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalValue = 96;

            for (int i = 5; i <= finalValue; i += 7)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

        }
    }
}
