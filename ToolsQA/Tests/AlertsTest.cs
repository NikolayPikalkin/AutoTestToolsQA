using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ToolsQA.PageObject;
using ToolsQA.Utils;

namespace ToolsQA.Tests
{
    public class AlertsTest : BaseTest
    {
        AlertsPageObject alertsPage = new AlertsPageObject();
        
        [Test]
        public void TestAlerts()
        {
            ActionsBrowser.NavigateTo(configModel.MainUrl);
            Assert.IsTrue(alertsPage.IsPageOpened(),"Main Page is not open");

            alertsPage.ClickCardAlerts();
            alertsPage.ClickSelectAlertsMenu();
            Assert.IsTrue(alertsPage.IsDisplayedFormAletrs(), "Alerts Form not found");

            alertsPage.ClickAlertButton();
            Assert.IsTrue(alertsPage.IsCheckTextAlertButton(), "Invalid text alert AlertButtton");
            
            Assert.IsTrue(alertsPage.IsCloseAlert(), "Alert is not closed");

            alertsPage.ClickConfirmButton();
            Assert.IsTrue(alertsPage.IsCheckTextConfirmButton(), "Invalid text alert ConfirmButton");

            alertsPage.ClickOkConfirmButtonAlert();
            Assert.IsTrue(alertsPage.IsCheckTextAfterClickConfirmButton(), "No button 'OK' selected");

            alertsPage.ClickPromptButton();
            Assert.IsTrue(alertsPage.IsCheckTextAlertPromptButton(), "Invalid text PromptButton");

            alertsPage.SendRandomTextInAlert();
            Assert.IsTrue(alertsPage.IsCheckTextResultPrompt(),"Invalid entered text");
        }
    }
}
