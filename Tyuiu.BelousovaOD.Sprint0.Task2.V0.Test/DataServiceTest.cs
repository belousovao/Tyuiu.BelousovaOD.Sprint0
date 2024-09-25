using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelousovaOD.Sprint0.Task2.Var0.Lib;

namespace Tyuiu.BelousovaOD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Ольга";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Ольга", res);
        }
    }
}
