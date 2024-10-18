using Tyuiu.FedotkinNE.Sprint1.Task4.V16.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            double x = ds.Calculate(1);
            double res = 0.2;
            Assert.AreEqual(x, res);
        }
    }
}