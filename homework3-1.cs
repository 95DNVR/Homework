using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string jobTitle;
            string veryImportantInformation;
            int age;
            int ageOfRetirement = 65;
            int yearsBeforeRetairement;
            bool ageCheck;
            int yearsAfterRetairement;

            Console.Write("Здравствуйте, вас приветствует система индетификации завод УралМаш, пожалуйста укажите ваше имя ");
            name = Console.ReadLine ();
            Console.Write(" Пожалуйста, назовите вашу должность ");
            jobTitle = Console.ReadLine ();
            Console.Write(" Пожалуйста, укажите ваш возраст ");
            age = Convert.ToInt32(Console.ReadLine ());

            ageCheck = age <= 65; // не додумался как обойтись без маг.числа
            yearsAfterRetairement = Convert.ToInt32(ageCheck);

            yearsBeforeRetairement = (ageOfRetirement - age) * yearsAfterRetairement;
            
            Console.WriteLine(" Организация благодарит за предоставленные вами данные. " +
                "Пожалуйста проверте точность данных " +
                "Ваше имя " + name + ".Вам " + age + "лет." +
                "Вы работаете на должности " + jobTitle + 
                ".До пенсии вам осталось "
                + yearsBeforeRetairement+ " лет...Задумайтесь)");
            Console.Write("Дам... тут возмущаются, что я пошел не по заданию и вместо того что бы спросить очень сложный и важный вопрос про задиак " +
                "сделал фигню с вычислением пенсионного возраста... так что если вам не трудно напишите пожалуйста ваш знак задиака ");
            veryImportantInformation = Console.ReadLine ();
            Console.WriteLine(" Организация благодарит за предоставленные вами данные. " +
               "Пожалуйста проверте точность данных " +
               "Ваше имя " + name + ".Вам " + age + " лет." +
               ".Вы работаете на должности " + jobTitle +
               ".До пенсии вам осталось "
               + yearsBeforeRetairement + " лет...Задумайтесь). Ого вы " + veryImportantInformation + " по знаку задиака. Чел Хароош)");




        }
    }
}
