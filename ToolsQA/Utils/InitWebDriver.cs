using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;
using ToolsQA.ConfigData;
using WebDriverManager.DriverConfigs.Impl;

namespace ToolsQA
{
    public sealed class InitWebDriver
    {
        private static IWebDriver driver = null;
        private InitWebDriver() { }

        public static IWebDriver GetDriver()
        {
            if(driver == null)
            {
                driver = BrowserFactory.InitBrowser(BaseTest.configModel.Browser);
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
