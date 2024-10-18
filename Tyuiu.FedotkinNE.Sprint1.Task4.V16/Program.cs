using Tyuiu.FedotkinNE.Sprint1.Task4.V16.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task4.V16
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
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*    вычисляет результат по формуле и печатает его на экране              *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double x;
            Console.WriteLine("Введите значения длины и ширины прямоугольника, а затем сторону квадрата: ");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();


        }
    }
}