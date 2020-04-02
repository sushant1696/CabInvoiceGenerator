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
        /// <summary>
        /// test case 1.2 (null check)
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturFalse()
        {
            Feet ft1 = new Feet(10);
            var result = ft1.Equals(null);
            Assert.IsFalse(result);

        }
        /// <summary>
        /// Test case 1.3 (null check)
        /// </summary>
        [Test]
        public void Ref_Check_ShouldReturFalse()
        {
            Feet f1 = new Feet(99);
            var actual = this.Equals(f1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Test Case 1.4 Type check
        /// </summary>
        [Test]
        public void Type_Check_ShouldReturTrue()
        {
            Feet f = new Feet(21);
            Feet f2 = new Feet(21);
            var expect = f.ConvertFeetValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 1.5 Type check
        /// </summary>
        [Test]
        public void GivenSameValue_ShouldReturForTrue()
        {
            Feet f = new Feet(21);
            Feet f2 = new Feet(21);
            var expect = f.ConvertFeetValue(f2);
            Assert.IsTrue(expect);
        }
    }
}
