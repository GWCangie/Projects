﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsInAutomation.Tests.Advanced.Core;
using PatternsInAutomation.Tests.Advanced.Observer.Classic.Attributes;
using B = PatternsInAutomation.Tests.Beginners.Selenium.Bing.Pages;

namespace PatternsInAutomation.Tests.Advanced.Observer.Classic
{
    [TestClass]
    [ExecutionBrowser(BrowserType = BrowserTypes.Firefox)]
    public class BingTestsClassicObserver : BaseTest
    {
        [TestMethod]
        [ExecutionBrowser(BrowserType = BrowserTypes.Chrome)]
        public void SearchTextInBing_First_Observer()
        {
            B.BingMainPage bingMainPage = new B.BingMainPage(Driver.Browser);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.ValidateResultsCount("RESULTS");
        }
    }
}