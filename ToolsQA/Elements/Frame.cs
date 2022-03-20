using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.Elements
{
    public class Frame : BaseElement
    {
        public Frame(By locator, string name) : base(locator, name)
        {

        }

        public void SwitchToFrame()
        {
            InitWebDriver.GetDriver().SwitchTo().Frame("frame1");
            IWebElement a = InitWebDriver.GetDriver().FindElement(By.CssSelector("html//body[contains(text(),'Parent frame')]"));
            Console.WriteLine(a.Text);
        }
    }
}
