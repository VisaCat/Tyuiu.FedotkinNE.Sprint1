using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FedotkinNE.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            return Math.Round((1) / (x + 4), 3);
        }
    }
}
