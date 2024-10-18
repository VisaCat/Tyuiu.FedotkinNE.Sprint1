using Tyuiu.FedotkinNE.Sprint1.Task5.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task5.V2
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
            Console.WriteLine("* определить значение температуры градусов фаренгейт в цельсия            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double x;
            Console.WriteLine("Введите значения длины и ширины прямоугольника, а затем сторону квадрата: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.FahrenheitToСelsius(x));
            Console.ReadKey();


        }
    }
}