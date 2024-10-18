using Tyuiu.FedotkinNE.Sprint1.Task3.V18.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            var x = ds.HowManySquares(6, 9, 3);
            int res = 6;
            Assert.AreEqual(x, res);
        }
    }
}