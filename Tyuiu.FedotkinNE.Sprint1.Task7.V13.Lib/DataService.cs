using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FedotkinNE.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            return (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12);
        }
    }
}
