﻿using PatternsInAutomation.Tests.Advanced.Unity.Base;

namespace PatternsInAutomation.Tests.Advanced.Unity.WikipediaMainPage.HardCore
{
    public interface IWikipediaMainPage<M, V> : IPage<M, V>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new() 
    {
        void Search(string textToType);

        void ToggleContents();
    }
}