using NUnit.Framework;
using System;

namespace IsTrue

    [TestFixture]
    public class Class1
    {

    [Test]
    public void InRange(int age)
    {
        age = 15;

        Assert.IsTrue(age >= 18, "Age must be at least 18"); // Test Fails

    }
    }
}
