using Classes;
using Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestContosoStockPrice()
        {
            // Arrange:

            // Create the fake stockFeed:
            var fakePerson = A.Fake<IPerson>();
            // Act:
            A.CallTo(() => fakePerson.Age).Returns(15);
            // Assert:
            Assert.AreEqual(15, fakePerson.Age);
        }
        [TestMethod]
        public void TestAddBall()
        {
            // Arrange:

            // Create the fake stockFeed:
            var fakePerson = A.Fake<IPerson>();
            IStudent student = new Student();
            // Act:
            A.CallTo(() => fakePerson.Age).Returns(15);
            // Assert:
            Assert.AreEqual(15, fakePerson.Age);
        }
    }
}
}
