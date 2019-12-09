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
            
        //(parameter, description )
            [TestCase("12345678", "is less than 10")]
            [TestCase("random", "it is string")]
            [TestCase("-1234567890", "has negative")]
            public void IsValidShouldReturnFalse(string egn, string message)
            {
                //Arrange
                var validator = new EgnValidator();

            //Act
            var condition = validator.IsValid(egn);

            //Assert
            Assert.IsFalse(condition, message); // All are false

            }

        [TestCase(null, "Is Null")]
        public void IsValidAcceptsNullAsParameter(string egn, string message)
        {
            //Arrange
            var validator = new EgnValidator();

            //Assert
            Assert.Throws<ArgumentNullException>(
                () => validator.IsValid(egn), message);
            //Assert.IsFalse(condition, message); // All are false

        }
    }
    }
