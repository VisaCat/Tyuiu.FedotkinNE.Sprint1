using Tyuiu.FedotkinNE.Sprint1.Task2.V26.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            var x = ds.CalculateMinutesSinceStart(5, 30);
            int res = 330;
            Assert.AreEqual(x, res);
        }
    }
}