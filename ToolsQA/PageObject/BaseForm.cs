using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.PageObject
{
    public abstract class BaseForm
    {
        public By uniqueElement;
        public string name;

        public BaseForm(By _uniqElem, string _name)
        {
            uniqueElement = _uniqElem;
            name = _name;
        }
        public bool IsPageOpened()
        {
            return InitWebDriver.GetDriver().FindElements(uniqueElement).Count > 0;
        }

        

    }

}






