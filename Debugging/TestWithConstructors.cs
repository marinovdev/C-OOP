namespace TestWithConstructors
    {
        using NUnit.Framework;
        using EgnHelper;
        using System;

        [TestFixture]
        public class EgnValidatorTests
        {

            [TestCase("9807144020")]
            [TestCase("0000000000")]
            [TestCase("1234567890")]
            [TestCase("4543535435")]
            [TestCase("5435345345")]
            public void IsValidShouldReturnTrue(string egn)
            {
                //Arrange
                var validator = new EgnValidator();

                //Act
                var result = validator.IsValid(egn);

                //Assert
                Assert.AreEqual(result, true); // true -> a valid Egn

            }

            [TestCase(null)]
            [TestCase("12345678")]
            [TestCase("random")]
            [TestCase("-1234567890")]
            public void IsValidShouldReturnFalse(string egn)
            {
                //Arrange
                var validator = new EgnValidator();

            //Act
            var condition = validator.IsValid(egn);

            //Assert
            Assert.IsFalse(condition); // All are false

            }
        }
    }
