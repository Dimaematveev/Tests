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
            
           
            var dat = A.Fake<DateTimeProvider>();
            A.CallTo(() => dat.Now).Returns(new DateTime(2001, 1, 1));
            var age = new Ages(new DateTime(2000, 1, 1));
            var age1 = A.Fake<Ages>();
            A.CallToSet(() => age1.SetDT).Returns(new DateTime(2001, 1, 1));
            var age2 = A.Dummy<Ages>();
            
            Assert.AreEqual(1, age.age);

        }
    }
}
