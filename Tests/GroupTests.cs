using Classes;
using FakeItEasy;
using Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class GroupTests
    {
        [TestMethod]
        public void TestContosoStockPrice()
        {
            // Arrange:
            List<IStudent> students = new List<IStudent>();
            for (int i = 0; i < 15; i++)
            {
                var fakePerson = A.Fake<IPerson>();
                A.CallTo(() => fakePerson.Age).Returns(15);
                A.CallTo(() => fakePerson.Name).Returns("Val");
                var fakeStudent = A.Fake<IStudent>();
                A.CallTo(() => fakeStudent.Person).Returns(fakePerson);
                A.CallTo(() => fakeStudent.avgBall).Returns(3.5d);
                students.Add(fakeStudent);
            }
            // Create the fake stockFeed:

            // Act:
            IGroup group = new Group();
            group.Students = students;


            // Assert:
            Assert.AreEqual(15, group.CountStudent);
            Assert.AreEqual(students, group.Students);
        }
    }
}
