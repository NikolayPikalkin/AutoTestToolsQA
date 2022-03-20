using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ToolsQA.PageObject;
using ToolsQA.Utils;

namespace ToolsQA.Tests
{
    public class FramesTest : BaseTest
    {
        FramePageObject framePage = new FramePageObject();

        //[Test]
        public void TestFrames()
        {
            ActionsBrowser.NavigateTo(configModel.MainUrl);
            Assert.IsTrue(framePage.IsPageOpened(), "Main Page is not open");
            
            framePage.ClickCardAlerts();
            framePage.ClickNestedFrames();
            Assert.IsTrue(framePage.IsDisplayedFormNestedFrames(), "Nested Frames Form not found");

            framePage.TextFrame();
        }
    }
}
