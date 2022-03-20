using OpenQA.Selenium;

namespace ToolsQA.PageObject
{
    public class AlertsPageObject : BaseForm
    {
        public AlertsPageObject() : base(By.XPath("//div[@class='home-banner']"), "UniqueElement"){  }
        private readonly Elements.Button cardAlerts = 
            new Elements.Button(By.XPath("//div[@class='card mt-4 top-card']//h5[contains(text(),'Alerts, Frame & Windows')]//parent::div//parent::div"), "AlertsCard");

        private readonly Elements.Button selectAlertsMenu = 
            new Elements.Button(By.XPath("//li[contains(@class,'btn btn-light')]//span[contains(text(),'Alerts')]"), "SelectAlertsMenu");

        private readonly Elements.Form formAlerts =
            new Elements.Form(By.XPath("//div[@id='javascriptAlertsWrapper']"), "AlertsForm");

        private readonly Elements.Button alertButton = 
            new Elements.Button(By.XPath("//button[@id='alertButton']"), "AlertButton");

        private readonly Elements.Button confirmButton =
            new Elements.Button(By.XPath("//button[@id='confirmButton']"), "ConfirmButton");

        private readonly Elements.Text textResultConfirm =
            new Elements.Text(By.XPath("//span[@id='confirmResult']"), "text alert confirmButton");
        private readonly Elements.Button promptButton =
            new Elements.Button(By.XPath("//button[@id='promtButton']"), "PromptButton");

        private readonly Elements.Text textResultPrompt =
            new Elements.Text(By.XPath("//span[@id='promptResult']"), "Result Text prompt");

        public void ClickCardAlerts()
        {
            cardAlerts.ClickElement();
        }
        public void ClickSelectAlertsMenu()
        {
            selectAlertsMenu.ClickElement();
        }
        public bool IsDisplayedFormAletrs()
        {
            return formAlerts.IsDisplayedElement();
        }
        public void ClickAlertButton()
        {
            alertButton.ClickElement();
        }
        public bool IsCheckTextAlertButton()
        {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            string text = alert.Text;
            if (text == BaseTest.testModel.TextAlertButton)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsCloseAlert()
        {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            alert.Accept();
            try
            {
                confirmButton.WaitElement();
                return true;
            }
            catch (NotFoundException) {
                return false;
            } 
        }

        public void ClickConfirmButton()
        {
            confirmButton.ClickElement();
        }
        public bool IsCheckTextConfirmButton() {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            string text = alert.Text;
            if(text == BaseTest.testModel.TextConfirmButton)
            {
                return true;
            }
            else
                return false;
        }
        public void ClickOkConfirmButtonAlert()
        {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            alert.Accept();
        }
        public bool IsCheckTextAfterClickConfirmButton()
        {
            string text = textResultConfirm.GetText();
            return BaseTest.testModel.TextAfterClickConfirmButton == text;
        }
        public void ClickPromptButton()
        {
            promptButton.ClickElement();
        }
        public bool IsCheckTextAlertPromptButton()
        {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            string text = alert.Text;
            if (text == BaseTest.testModel.TextPromptButton)
            {
                return true;
            }
            else
                return false;
        }
        public void SendRandomTextInAlert()
        {
            IAlert alert = WaitUntil.WaitAlerts(InitWebDriver.GetDriver());
            string text = GenerateRandomText.GenerateText(BaseTest.testModel.CountRandomSimbols);
            BaseTest.testModel.RandomText = text;
            alert.SendKeys(text);
            alert.Accept();
        }
        public bool IsCheckTextResultPrompt()
        {
            string text = textResultPrompt.GetText();
            text = OperationString.RemovePartString(text, BaseTest.testModel.RemoveText);
            return text == BaseTest.testModel.RandomText;
        }
    }
}
