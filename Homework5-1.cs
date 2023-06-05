using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Симонов";
            string surName = "Денис";
            string auxiliaryVariable;

            Console.Write("Ваше имя " + name + " ваша фамилия " + surName);
            Console.WriteLine(" Перестановка переменных ");
            auxiliaryVariable = Convert.ToString(name);
            name = Convert.ToString(surName);
            surName = Convert.ToString(auxiliaryVariable);
            Console.WriteLine(" Ваше имя " + name + " ваша фамилия " + surName)
        }
    }
}
