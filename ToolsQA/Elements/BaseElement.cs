using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.Elements
{
    public class BaseElement
    {
        public By locator;
        public string name;

        public BaseElement(By _locator, string _name)
        {
            locator = _locator;
            name = _name;
            
        }
        public void ClickElement()
        {
            InitWebDriver.GetDriver().FindElement(locator).Click();
        }

        public void WaitElement()
        {
            WaitUntil.WaitElement(InitWebDriver.GetDriver(), locator);
        }

        public bool IsDisplayedElement()
        {
            return InitWebDriver.GetDriver().FindElements(locator).Count > 0;
        }
    }
}
