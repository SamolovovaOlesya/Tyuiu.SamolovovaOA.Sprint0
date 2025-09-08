using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamolovovaOA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SamolovovaOA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Олеся";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Олеся", res);
        }
    }
}
