using Classes;
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
    public class PersonTests
    {
        [TestMethod]
        public void TestSetAge()
        {
            // Arrange:
            

            int age = 15;
            
            // Act:
            IPerson person = new Person();
            person.SetAge(age);
            // Assert:
            Assert.AreEqual(age, person.Age);
        }
        [TestMethod]
        public void TestSetName()
        {
            // Arrange:


            string Name = "Name";

            // Act:
            IPerson person = new Person();
            person.SetName(Name);
            // Assert:
            Assert.AreEqual(Name, person.Name);
        }

        [TestMethod]
        public void TestGetAge()
        {
            // Arrange:


            int age = 15;

            // Act:
            IPerson person = new Person();
            person.Age=age;
            // Assert:
            Assert.AreEqual(age, person.GetAge());
        }
        [TestMethod]
        public void TestGetName()
        {
            // Arrange:


            string Name = "Name";

            // Act:
            IPerson person = new Person();
            person.Name = Name;
            // Assert:
            Assert.AreEqual(Name, person.GetName());
        }
    }
}
