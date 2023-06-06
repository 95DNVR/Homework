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
            string surname = "Денис";
            string bufferName;

            Console.Write("Ваше имя " + name + " ваша фамилия " + surname);
            Console.WriteLine(" Перестановка переменных ");
            bufferName = name;
            name = surname;
            surname = bufferName;
            Console.WriteLine(" Ваше имя " + name + " ваша фамилия " + surname);
        }
    }
}
