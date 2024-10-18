using Tyuiu.FedotkinNE.Sprint1.Task5.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            double x = ds.FahrenheitToСelsius(20);
            double res = -7;
            Assert.AreEqual(x, res);
        }
    }
}