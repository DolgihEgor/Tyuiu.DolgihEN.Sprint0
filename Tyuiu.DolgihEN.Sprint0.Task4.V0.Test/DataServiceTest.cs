using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.DolgihEN.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        // Сложение
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        // Вычитание
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        // Умножение
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        // Деление
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
