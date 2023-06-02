using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = (" Ответ будет ноль, так как выражение (31-5*10)/38 в своем ответе содержит дробное число -0,55... однако переменные в нашем коде заданны целочисленные соответственно ничего кроме нуля в консоль не выведится. " +
                "Фиксится сменой переменной либо при обьявлении (записать не int a float), либо конвертацией значений в самом уравнении при помощи (convert.ToSingle) ");
        }
    }
}
