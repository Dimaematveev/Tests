﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            // Create the fake stockFeed:
            //IStockFeed stockFeed =
            //     new StockAnalysis.Fakes.StubIStockFeed() // Generated by Fakes.
            //     {
            //         // Define each method:
            //         // Name is original name + parameter types:
            //         GetSharePriceString = (company) => { return 1234; }
            //     };

            //// In the completed application, stockFeed would be a real one:
            //var componentUnderTest = new StockAnalyzer(stockFeed);

            //// Act:
            //int actualValue = componentUnderTest.GetContosoPrice();

            //// Assert:
            //Assert.AreEqual(1234, actualValue);
        }
    }
}
