using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FedotkinNE.Sprint1.Task0.V2.Lib
{
    public class DataService
    {
        public static int Get(int a, int b, int c, int d, int s)
        {
            return a / a * b + c / d / a - s; //3/3*2+12/4/3-2
                                              //3/3*  2+  12/ 4/  3-  2
        }
        public static int Addiction(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!", b);
                return -1;
            }
            else
            {
                return a / b;
            }

        }
    }
}
