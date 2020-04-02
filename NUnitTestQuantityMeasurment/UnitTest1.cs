using NUnit.Framework;
using QuantityMeasurmentProject;

namespace NUnitTestQuantityMeasurment
{
    public class Tests
    {
        /// <summary>
        /// Test Case 1.1 where given 0 feet and return 0 feet equals
        /// </summary>
      [Test]
      public void GivenFeet_ShouldReturnFeetEqual()
        {
            Feet ft = new Feet(0);
            Feet ft2 = new Feet(0);
            var result = ft.ConvertFeetValue(ft2);
            Assert.IsTrue(result);
        }

    }
}
