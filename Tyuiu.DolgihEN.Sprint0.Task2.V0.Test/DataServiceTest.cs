using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DolgihEN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DolgihEN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов, тестирования, методов из библиотеки 
            var name = "Егор";
            var res = DataService.GetMessage(name);

            //Вызывает класс Assert
            Assert.AreEqual("Привет..., Егор", res);
        }
    }
}
