using Tyuiu.FedotkinNE.Sprint1.Task7.V13.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание 7                                                               *");
            Console.WriteLine("* Выполнил: Федоткин Никита Евгеньевич | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вывести результат уравнения                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();

            Console.WriteLine("Введите x и y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();


        }
    }
}
