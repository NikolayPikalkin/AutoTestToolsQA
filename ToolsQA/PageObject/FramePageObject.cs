using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.PageObject
{
    public class FramePageObject : BaseForm
    {
        public FramePageObject() : base(By.XPath("//div[@class='home-banner']"), "UniqueElement") { }
        private readonly Elements.Button cardAlerts =
            new Elements.Button(By.XPath("//div[@class='card mt-4 top-card']//h5[contains(text(),'Alerts, Frame & Windows')]//parent::div//parent::div"), "AlertsCard");
        
        private readonly Elements.Button selectNestedFramesMenu =
            new Elements.Button(By.XPath("//li[contains(@class,'btn btn-light')]//span[contains(text(),'Nested Frames')]//parent::li"), "Nested Frames");

        private readonly Elements.Form formNestedFrames =
            new Elements.Form(By.XPath("//div[@id='framesWrapper']"), "NestedFramesForm");

        private readonly Elements.Frame textIframe =
            new Elements.Frame(By.CssSelector("iframe[id=frame1]"), "Text Iframe");


        public void ClickCardAlerts()
        {
            cardAlerts.ClickElement();
        }
        public void ClickNestedFrames()
        {
            selectNestedFramesMenu.WaitElement();
            selectNestedFramesMenu.ClickElement();
        }

        public bool IsDisplayedFormNestedFrames()
        {
            return formNestedFrames.IsDisplayedElement();
        }

        public void TextFrame()
        {
            textIframe.SwitchToFrame();
        }

    }
}
