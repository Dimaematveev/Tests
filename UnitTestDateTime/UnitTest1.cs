using System;
using ClassesDate;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDateTime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgeTest()
        {
            Ages age = new Ages(new DateTime(2000, 8, 8));
            A.Fake<IDateTimeProvider>(()=> Now)
            Assert.AreEqual(19, age.age);
        }
    }
}
