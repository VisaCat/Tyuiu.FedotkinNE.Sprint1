



using System;
using Tyuiu.FedotkinNE.Sprint1.Task0.V2.Lib;

namespace Tyuiu.FedotkinNE.Sprint1.Task0.V2
{
    internal class class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание 0                                                               *");
            Console.WriteLine("* Выполнил: Федоткин Никита Евгеньевич | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 3/3*2+12/4/3-2          *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("3 / 3 * 2 + 12 / 4 / 3 - 2");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate());

            Console.ReadKey();


        }
    }
}
