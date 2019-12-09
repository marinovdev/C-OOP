
namespace EgnHelper.Tests
{
using NUnit.Framework;
    using System;

    [TestFixture]
    public class EgnValidatorTests
    {

        [TestCase]
        public void MathShouldWorkCorrectlyForPowerOf2()
        {
            //Adjust
            //Act
            //Assert
            var result = Math.Pow(100, 2);

            Assert.AreEqual(10001, result); //Expected 10001 But was 10000

            //same as :

            Assert.That(result, Is.EqualTo(10000));
            
            // same as :
            
            if(result != 10000)
            {
                throw new ArgumentException($"{nameof(result)} was expected to be 10 000");
            }
        }
    }
}
