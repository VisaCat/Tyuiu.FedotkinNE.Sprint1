

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedotkinNE.Sprint1.Task1.V26.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            DataService ds = new DataService();
            var x = ds.Calculate(5, 3);
            int res = 5;
            Assert.AreEqual(x, res);
        }

    }
}