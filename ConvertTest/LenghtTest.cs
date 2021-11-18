using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertWeight;

namespace LenghtTest
{
    [TestClass()]
    public class LenghtTest
    {
        [TestMethod()]
        public void KilometersToMilesTest()
        {
            //arrange
            double km = 23;
            double expected = 14.2915;

            //assert
            Assert.AreEqual(expected, Weight.KilometersToMiles(km));

        }
        [TestMethod()]
        public void MilestoKilometrsTest()
        {
            //arrange
            double mil = 45;
            double expected = 72.4205;

            //assert
            Assert.AreEqual(expected, Weight.MilesToKilometers(mil));

        }
        [TestMethod()]
        public void FootsToMetersTest()
        {
            //arrange
            double f = 10000 ;
            double expected = 3048;

            //assert
            Assert.AreEqual(expected, Weight.FootsToMeters(f));

        }
        [TestMethod()]
        public void MetersToFootsTest()
        {
            //arrange
            double m = 2;
            double expected = 6.5617;

            //assert
            Assert.AreEqual(expected, Weight.MetersToFoots(m));

        }
        [TestMethod()]
        public void KilometersToFootsTest()
        {
            //arrange
            double km = 1;
            double expected = 3280.8399;

            //assert
            Assert.AreEqual(expected, Weight.KilometersToFoots(km));

        }
        [TestMethod()]
        public void FootsToKilometersTest()
        {
            //arrange
            double f = 4000;
            double expected = 1.2192;

            //assert
            Assert.AreEqual(expected, Weight.FootsToKilometers(f));

        }
        [TestMethod()]
        public void MilesToFootsTest()
        {
            //arrange
            double mil = 3;
            double expected = 15840;

            //assert
            Assert.AreEqual(expected, Weight.MilesToFoots(mil));

        }
        [TestMethod()]
        public void FootsToMilesTest()
        {
            //arrange
            double f = 25000;
            double expected = 4.7348;

            //assert
            Assert.AreEqual(expected, Weight.FootsToMiles(f));

        }
        [TestMethod()]
        public void KilometersToMetersTest()
        {
            //arrange
            double km = 4;
            double expected = 4000;

            //assert
            Assert.AreEqual(expected, Weight.KilometersToMeters(km));

        }
        [TestMethod()]
        public void MetersToKilometersTest()
        {
            //arrange
            double m = 4000;
            double expected = 4;

            //assert
            Assert.AreEqual(expected, Weight.MetersToKilometers(m));

        }
        [TestMethod()]
        public void MilesToMetersTest()
        {
            //arrange
            double mil= 3;
            double expected = 4828.032;

            //assert
            Assert.AreEqual(expected, Weight.MilesToMeters(mil)); ;

        }
        [TestMethod()]
        public void MetersToMilesTest()
        {
            //arrange
            double m = 2000 ;
            double expected = 1.2427;

            //assert
            Assert.AreEqual(expected, Weight.MetersToMiles(m));

        }
    }
}