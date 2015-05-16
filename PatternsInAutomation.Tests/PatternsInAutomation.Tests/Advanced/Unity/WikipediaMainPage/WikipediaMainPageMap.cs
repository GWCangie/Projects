﻿using OpenQA.Selenium;
using PatternsInAutomation.Tests.Advanced.Unity.Base;

namespace PatternsInAutomation.Tests.Advanced.Unity.WikipediaMainPage
{
    public class WikipediaMainPageMap : BasePageElementMap
    {
        public IWebElement SearchBox 
        {
            get
            {
                return this.browser.FindElement(By.Id("searchInput"));
            }
        }

        public IWebElement SearchButton 
        {
            get
            {
                return this.browser.FindElement(By.Id("searchButton"));
            }
        }

        public IWebElement ContentsToggleLink
        {
            get
            {
                return this.browser.FindElement(By.Id("togglelink"));
            }
        }

        public IWebElement ContentsList
        {
            get
            {
                return this.browser.FindElement(By.XPath("//*[@id='toc']/ul"));
            }
        }
    }
}