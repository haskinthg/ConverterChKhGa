using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ConvertTemperature;
using System;

namespace RateTest
{
    [TestClass()]
    public class TempTest
    {
        [TestMethod()]
        public void FtoCtest()
        {
            //arrange
            double F = 50;
            double expected = 10;

            Assert.AreEqual(expected, ConvertationTemp.FtoC(F));
        }

        [TestMethod()]
        public void CtoFtest()
        {
            //arrange
            double C = 15;
            double expected = 59;

            Assert.AreEqual(expected, ConvertationTemp.CtoF(C));
        }

        [TestMethod()]
        public void KtoFtest()
        {
            //arrange
            double K = 260.93;
            double expected = 10;

            Assert.AreEqual(expected, ConvertationTemp.KtoF(K));
        }

        [TestMethod()]
        public void FtoKtest()
        {
            //arrange
            double F = 5;
            double expected = 258.15;

            Assert.AreEqual(expected, ConvertationTemp.FtoK(F));
        }

        [TestMethod()]
        public void KtoCtest()
        {
            //arrange
            double K = 300.15;
            double expected = 27;

            Assert.AreEqual(expected, ConvertationTemp.KtoC(K));
        }

        [TestMethod()]
        public void CtoKtest()
        {
            //arrange
            double C = 45;
            double expected = 318.15;

            Assert.AreEqual(expected, ConvertationTemp.CtoK(C));
        }

    }
}
