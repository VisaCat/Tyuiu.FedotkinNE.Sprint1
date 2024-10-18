

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedotkinNE.Sprint1.Task0.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            var x = ds.Calculate();
            int res = 1;
            Assert.AreEqual(x, res);
        }

    }
}
