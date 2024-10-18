using Tyuiu.FedotkinNE.Sprint1.Task6.V3.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task6.V3
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
            
            Console.WriteLine("Введите текст: ");
            
            string text = Console.ReadLine();
            string x = ds.LastLetterWord(text);

            Console.WriteLine("Строка из последних букв слов: " + x);
            Console.ReadKey();


        }
    }
}