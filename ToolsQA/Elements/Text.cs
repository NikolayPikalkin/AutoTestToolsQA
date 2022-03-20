using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.Elements
{
    public class Text : BaseElement
    {
        public Text(By locator, string name) : base(locator, name)
        {

        }

        public string GetText()
        {
            return InitWebDriver.GetDriver().FindElement(locator).Text;
        }

        public void SendText(string text)
        {
            InitWebDriver.GetDriver().FindElement(locator).SendKeys(text);
        }
    }
}
