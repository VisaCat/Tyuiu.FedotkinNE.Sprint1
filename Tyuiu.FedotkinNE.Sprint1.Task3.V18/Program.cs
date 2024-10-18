using Tyuiu.FedotkinNE.Sprint1.Task3.V18.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task3.V18
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
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Написать программу, которая вычисляет, сколько кадратов стороной С можно  ");
            Console.WriteLine(" разместить в треугольнике c размерами А и В без наложений                 ");

            Console.WriteLine("                                                                           ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double a, b, c;
            Console.WriteLine("Введите значения длины и ширины прямоугольника, а затем сторону квадрата: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.HowManySquares(a, b, c));
            Console.ReadKey();


        }
    }
}
