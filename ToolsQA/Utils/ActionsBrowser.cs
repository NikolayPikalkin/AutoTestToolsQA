using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToolsQA.Utils
{
    public static class ActionsBrowser
    {
        public static void NavigateTo(string url)
        {
            InitWebDriver.GetDriver().Navigate().GoToUrl(url);
            WaitUntil.WaitDownloadUrl(InitWebDriver.GetDriver(), url);
        }
        public static void NavigateBack()
        {
            InitWebDriver.GetDriver().Navigate().Back();
        }
        public static void NavigateForward()
        {
            InitWebDriver.GetDriver().Navigate().Forward();
        }
        public static void NavigateRefresh()
        {
            InitWebDriver.GetDriver().Navigate().Refresh();
        }
        public static void SettingSize(int width, int height)
        {
            InitWebDriver.GetDriver().Manage().Window.Size = new Size(width, height);
            //InitWebDriver.GetDriver().Manage().Window.Maximize();
        }
    }
}
