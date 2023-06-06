using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrannies;
            int visitTime = 10;
            int hourTime = 60;
            int vaitingTimeHours;
            int vaitingTimeMinutes;
            int placeLine;

            Console.Write(" Здравствуйте, добро пожаловать в элетронную очередь( внимание элекрофкация очереди не делает ожидание быстрее). Введите количество пациэнтов в очереди ");
            numberOfGrannies = Convert.ToInt32(Console.ReadLine());
            visitTime = numberOfGrannies * visitTime;
            vaitingTimeHours = visitTime / hourTime;
            vaitingTimeMinutes = visitTime % hourTime;
            placeLine = ++numberOfGrannies;
            Console.WriteLine(" Ваше место в очереди " + placeLine + " примерное время ожидания " + vaitingTimeHours + " часов " + vaitingTimeMinutes + " минут. Ожидайте");
        }
    }
}
