using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoRaulMCD;
using System;

namespace UnitTestProject1RaulMCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int esperado = 12;
            int actual = PruebaUnitaria.CalcularCuatroNumMCD(36, 48, 60, 72);
            Assert.AreEqual(esperado, actual);
        }
    }
}
