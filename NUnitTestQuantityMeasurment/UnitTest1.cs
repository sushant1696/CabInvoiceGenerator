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
        /// <summary>
        /// TestCase 1.14
        /// </summary>
        [Test]
        public void Given1Feet_And_1Inch_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Inches inch = new Inches(1);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// tc 1.15
        /// </summary>
        [Test]
        public void Given1Feet_And_12Inch_ShouldReturnEqual()
        {
            Inches inch = new Inches(1);
            Feet feet = new Feet(12 * inch.inch);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// tc 1.16
        /// </summary>
         [Test]
        public void Given12Inch_And_1feet_ShouldReturnTrue()
        {
            Inches inch = new Inches(12);
            Feet feet = new Feet(1);
            FeetToInches test = new FeetToInches(feet, inch);
            var actual = test.ComparedFeetAndinchesValue(feet, inch);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Test Case 2.1 where given 0 yard and return 0 yard equals
        /// </summary>
        [Test]
        public void GivenFeet_ShouldReturnYardEqual()
        {
            Yard yr = new Yard(0);
            Yard yr2 = new Yard(0);
            var result = yr.ConvertYardValue(yr2);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// test case 2.2 (null check)
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturFalseForYard()
        {
            Yard ft1 = new Yard(10);
            var result = ft1.Equals(null);
            Assert.IsFalse(result);

        }
        /// <summary>
        /// Test case 2.3 (ref check)
        /// </summary>
        [Test]
        public void Ref_Check_ShouldReturFalseYard()
        {
            Yard f1 = new Yard(99);
            var actual = this.Equals(f1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Test Case 2.4 Type check
        /// </summary>
        [Test]
        public void Type_Check_ShouldReturTrueYard()
        {
            Yard yrr = new Yard(21);
            Yard yrr2 = new Yard(21);
            var expect = yrr.ConvertYardValue(yrr2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 2.5 Type check
        /// </summary>
        [Test]
        public void GivenSameValue_ShouldReturForYardTrue()
        {
            Yard r1 = new Yard(21);
            Yard r2 = new Yard(21);
            var expect = r1.ConvertYardValue(r2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 2.6 given diferent value
        /// </summary>
        [Test]
        public void GivenDiferentValue_ShouldReturForYardFalse()
        {
            Yard rr = new Yard(21);
            Yard rr2 = new Yard(999);
            var expect = rr.ConvertYardValue(rr2);
            Assert.IsFalse(expect);
        }
        /// <summary>
        /// Test case 2.7
        /// </summary>
        [Test]
        public void Given0Feet_And_0Yard_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            Yard yrd = new Yard(0);
            FeedToYard test = new FeedToYard(feet, yrd);
            var actual = test.ComparedFeetToYardValue(feet, yrd);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// TestCase 2.8
        /// </summary>
        [Test]
        public void Given1Feet_And_1Inch_ShouldReturnFalseForFeetToYard()
        {
            Feet feet = new Feet(1);
            Yard yrd = new Yard(1);
           FeedToYard test = new FeedToYard(feet, yrd);
            var actual = test.ComparedFeetToYardValue(feet, yrd);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// tc 2.9
        /// </summary>
        [Test]
        public void Given3Feet_And_1yard_ShouldReturnEqualFeetToYard()
        {
            Yard yrd = new Yard(1);
            Feet feet = new Feet(12 * yrd.yrd);
            FeedToYard test = new FeedToYard(feet, yrd);
            var actual = test.ComparedFeetToYardValue(feet, yrd);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// tc 2.10
        /// </summary>
        [Test]
        public void Given3Feet_And_1Yard_ShouldReturnTrueFeetToYard()
        {
            Yard yrd = new Yard(12);
            Feet feet = new Feet(1);
            FeedToYard test = new FeedToYard(feet, yrd);
            var actual = test.ComparedFeetToYardValue(feet, yrd);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Test case 3.1
        /// </summary>
        [Test]
        public void Given0Kg_And_0Gm_ShouldReturnEqual()
        {
            Kilogram kg = new Kilogram(0);
            Gram gm = new Gram(0);
            KilogramToGram test = new KilogramToGram(kg, gm);
            var actual = test.ComparedKilogramAndGramValue(kg, gm);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void Given1kg_And_1gm_ShouldReturnFalseForKgToGm()
        {
            Kilogram kg = new Kilogram(1);
            Gram gm = new Gram(1);
            KilogramToGram test = new KilogramToGram(kg,gm);
            var actual = test.ComparedKilogramAndGramValue(kg, gm);
            Assert.IsFalse(actual);
        }
        ///// <summary>
        ///// tc 3.3
        ///// </summary>
        //[Test]
        //public void Given1000gm_And_1kg_ShouldReturnEqualKgToGm()
        //{
        //    Kilogram kg = new Kilogram(1);
        //    Gram gm = new Gram(1000 * gm.grm);
        //    KilogramToGram test = new KilogramToGram(kg, gm);
        //    var actual = test.ComparedKilogramAndGramValue(kg, gm);
        //    Assert.IsTrue(actual);
        //}
        ///// <summary>
        ///// tc 3.4
        ///// </summary>
        //[Test]
        //public void Given1kg_And_1000gm_ShouldReturnTrueKgToGm()
        //{
        //    Kilogram kg = new Kilogram(1);
        //    Gram gm = new Gram(1000 * gm.grm);
        //    KilogramToGram test = new KilogramToGram(kg, gm);
        //    var actual = test.ComparedKilogramAndGramValue(kg, gm);
        //    Assert.IsTrue(actual);
        //}
        /// <summary>
        /// Test Case 4.1 where given 0 feet and return 0 feet equals
        /// </summary>
        [Test]
        public void GivencCelcius_ShouldReturnCelciusEqual()
        {
            Celcius ft = new Celcius(0);
            Celcius ft2 = new Celcius(0);
            var result = ft.ConvertCelciusValue(ft2);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// test case 4.2 (null check)
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturFalseCelcius()
        {
            Celcius ft1 = new Celcius(10);
            var result = ft1.Equals(null);
            Assert.IsFalse(result);

        }
        /// <summary>
        /// Test case 4.3 (null check)
        /// </summary>
        [Test]
        public void Ref_Check_ShouldReturFalseCelcius()
        {
            Celcius f1 = new Celcius(99);
            var actual = this.Equals(f1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Test Case 4.5 Type check
        /// </summary>
        [Test]
        public void Type_Check_ShouldReturTrueCelcius()
        {
           Celcius f = new Celcius(21);
            Celcius f2 = new Celcius(21);
            var expect = f.ConvertCelciusValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 4.6 Type check
        /// </summary>
        [Test]
        public void GivenSameValue_ShouldReturForTrueCelcius()
        {
            Celcius f = new Celcius(21);
            Celcius f2 = new Celcius(21);
            var expect = f.ConvertCelciusValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 4.7 given diferent value
        /// </summary>
        [Test]
        public void GivenDiferentValue_ShouldReturForFalseCelcius()
        {
            Celcius f = new Celcius(21);
            Celcius f2 = new Celcius(999);
            var expect = f.ConvertCelciusValue(f2);
            Assert.IsFalse(expect);
        }
        /// <summary>
        /// Test Case 4.8 where given 0 Fahrenheit and return 0 Fahrenheit equals
        /// </summary>
        [Test]
        public void GivencFahrenheit_ShouldReturnCelciusEqual()
        {
            Fahrenheit ft = new Fahrenheit(0);
            Fahrenheit ft2 = new Fahrenheit(0);
            var result = ft.ConvertFahrenheitValue(ft2);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// test case 4.9 (null check)Fahrenheit
        /// </summary>
        [Test]
        public void GivenNull_ShouldReturFalseFahrenheit()
        {
            Fahrenheit ft1 = new Fahrenheit(10);
            var result = ft1.Equals(null);
            Assert.IsFalse(result);

        }
        /// <summary>
        /// Test case 4.10 (null check)Fahrenheit
        /// </summary>
        [Test]
        public void Ref_Check_ShouldReturFalseFahrenheit()
        {
            Fahrenheit f1 = new Fahrenheit(99);
            var actual = this.Equals(f1);
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Test Case 4.11 Type check
        /// </summary>
        [Test]
        public void Type_Check_ShouldReturTrueFahrenheit()
        {
            Fahrenheit f = new Fahrenheit(21);
            Fahrenheit f2 = new Fahrenheit(21);
            var expect = f.ConvertFahrenheitValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 4.12 Type check
        /// </summary>
        [Test]
        public void GivenSameValue_ShouldReturForTrueFahrenheit()
        {
            Fahrenheit f = new Fahrenheit(21);
            Fahrenheit f2 = new Fahrenheit(21);
            var expect = f.ConvertFahrenheitValue(f2);
            Assert.IsTrue(expect);
        }
        /// <summary>
        /// Test Case 4.13 given diferent value
        /// </summary>
        [Test]
        public void GivenDiferentValue_ShouldReturForFalseFahrenheit()
        {
            Fahrenheit f = new Fahrenheit(21);
            Fahrenheit f2 = new Fahrenheit(999);
            var expect = f.ConvertFahrenheitValue(f2);
            Assert.IsFalse(expect);
        }
    }
}
