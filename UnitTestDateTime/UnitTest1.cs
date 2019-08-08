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
            Ages age = new Ages(new DateTime(2000, 1, 1));
            var dat = A.Fake<DateTimeProvider>();
            A.CallTo(() => DateTimeProvider.Now).Returns(new DateTime(2001, 1, 1));
            Assert.AreEqual(1, age.age);
        }
    }
}
