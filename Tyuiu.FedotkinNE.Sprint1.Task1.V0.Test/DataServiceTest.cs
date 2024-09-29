using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Tyuiu.FedotkinNE.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int x = 3 / 3 * 2 + 12 / 4 / 3 - 2;
            int res = 1;
            Assert.AreEqual(x, res);
        }

    }
}
