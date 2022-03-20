using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ToolsQA.PageObject;
using ToolsQA.Utils;

namespace ToolsQA.Tests
{
    public class TablesTest : BaseTest
    {
        TablesPageObject tablesPage = new TablesPageObject();
        [Test]
        public void TestTables()
        {
            ActionsBrowser.NavigateTo(configModel.MainUrl);
            Assert.IsTrue(tablesPage.IsPageOpened(), "Main Page is not open");

            tablesPage.ClickCardElements();
            tablesPage.ClickWebTables();
            Assert.IsTrue(tablesPage.IsTableDisplayed(), "Table is not displayed");

            tablesPage.ClickAddButton();
            Assert.IsTrue(tablesPage.IsRegFormDisplayed(), "Register Form is not found");

            tablesPage.EnterDataUser();
            tablesPage.SubmitButtonClick();
        }
    }
}
