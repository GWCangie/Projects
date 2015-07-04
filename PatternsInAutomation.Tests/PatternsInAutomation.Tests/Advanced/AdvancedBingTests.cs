﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsInAutomation.Tests.Advanced.Core;
using P = PatternsInAutomation.Tests.Advanced.BingMainPage;

namespace PatternsInAutomation.Tests.Advanced
{
    [TestClass]
    public class AdvancedBingTests
    {       
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchTextInBing_Advanced_PageObjectPattern()
        {
            P.BingMainPage bingMainPage = new P.BingMainPage();
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().ResultsCount(",000 RESULTS");
        }
    }
}