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
            A.CallTo(() => fakePerson.Name).Returns("Dima");
            student.Person=fakePerson;
            student.AddBall(3.5);
            // Assert:
            Assert.AreEqual(3.5d, student.avgBall);
            Assert.AreEqual(fakePerson, student.Person);
        }
    }
}

