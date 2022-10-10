﻿using System;
using Microsoft.Playwright;
using Playwright.POC.Browsers;
using Playwright.POC.Profiles;

namespace Playwright.POC.Tests
{
    public class BaseFixture : IDisposable
    {
        //public readonly PageLoader PageLoader;
        
        public readonly ITestProfile Profile;
        public readonly IBrowser Browser;

        public BaseFixture()
        {
            var browserFactory = new BrowserFactory(true);
            //PageLoader = new PageLoader();
            Profile = TestProfileFactory.GetDefaultProfile();
            Browser = browserFactory.LaunchBrowser().Result;
        }

        public void Dispose()
        {
            Browser.CloseAsync();
        }
    }
}