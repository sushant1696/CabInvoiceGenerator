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
        /// <summary>
        /// Test Case 1.6 given diferent value
        /// </summary>
        [Test]
        public void GivenDiferentValue_ShouldReturForFalse()
        {
            Feet f = new Feet(21);
            Feet f2 = new Feet(999);
            var expect = f.ConvertFeetValue(f2);
            Assert.IsFalse(expect);
        }
        /// <summary>
        /// Test Case 1.7 where given 0 feet and return 0 feet equals
        /// </summary>
        [Test]
        public void Giveninch_ShouldReturnFeetEqual()
        {
            Inches inch = new Inches(0);
            Inches inch2 = new Inches(0);
            var result = inch.ConvertInchValue(inch2);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// test case 1.8 (null check)
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturFalseForInch()
        {
            Inches in1 = new Inches(10);
            var result = in1.Equals(null);
            Assert.IsFalse(result);

        }
        /// <summary>
        /// Test case 1.9 ref chech
        /// </summary>
        [Test]
        public void Ref_Check_ShouldReturFalseForInch()
        {
            Inches in2 = new Inches(99);
            var actual = this.Equals(in2);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Test Case 1.10 Type check
        /// </summary>
        [Test]
        public void Type_Check_ShouldReturTrueForInch()
        {
            Inches inn = new Inches(21);
            Inches inn2 = new Inches(21);
            var expect = inn.ConvertInchValue(inn2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 1.11 Type check
        /// </summary>
        [Test]
        public void GivenSameValue_ShouldReturForTrueForInch()
        {
            Inches f = new Inches(21);
            Inches f2 = new Inches(21);
            var expect = f.ConvertInchValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 1.12 given diferent value
        /// </summary>
        [Test]
        public void GivenDifferentValue_ShouldReturFalseForInch()
        {
            Inches inc = new Inches(21);
            Inches inc2 = new Inches(99);
            var expect = inc.ConvertInchValue(inc2);
            Assert.IsFalse(expect);
        }
        /// <summary>
        /// Test case 1.13
        /// </summary>
        [Test]
        public void Given0Feet_And_0Inch_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            Inches inch = new Inches(0);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsTrue(actual);
        }
       
    }
}
