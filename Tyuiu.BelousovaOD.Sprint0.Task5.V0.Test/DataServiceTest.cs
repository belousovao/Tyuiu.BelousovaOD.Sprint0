using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelousovaOD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BelousovaOD.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void ChekDiisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

        private void ChekedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        private void ChekedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        private void ChekedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
    }
}
