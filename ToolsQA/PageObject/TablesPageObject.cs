using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.PageObject
{
    public class TablesPageObject : BaseForm
    {
        public TablesPageObject() : base(By.XPath("//div[@class='home-banner']"), "UniqueElement") { }

        private readonly Elements.Button cardElements =
            new Elements.Button(By.XPath("//div[@class='card mt-4 top-card']//h5[contains(text(),'Elements')]//parent::div//parent::div"), "ElementsCard");

        private readonly Elements.Button selectWebTables =
            new Elements.Button(By.XPath("//li[contains(@class,'btn btn-light')]//span[contains(text(),'Web Tables')]//parent::li"), "WebTables");

        private readonly Elements.Table table =
            new Elements.Table(By.XPath("//div[@class='web-tables-wrapper']"), "Table");
        private readonly Elements.Button addButton =
            new Elements.Button(By.XPath("//button[@id='addNewRecordButton']"), "AddButton");
        private readonly Elements.Form registrForm =
            new Elements.Form(By.XPath("//div[@class='modal-content']"), "Register Form");
        
        private readonly Elements.Text firstName =
            new Elements.Text(By.XPath("//input[@id='firstName']"), "firstName");
        private readonly Elements.Text lastName =
            new Elements.Text(By.XPath("//input[@id='lastName']"), "lastName");
        private readonly Elements.Text userEmail =
           new Elements.Text(By.XPath("//input[@id='userEmail']"), "userEmail");
        private readonly Elements.Text age =
           new Elements.Text(By.XPath("//input[@id='age']"), "age");
        private readonly Elements.Text salary =
           new Elements.Text(By.XPath("//input[@id='salary']"), "salary");
        private readonly Elements.Text department =
           new Elements.Text(By.XPath("//input[@id='department']"), "department");
        private readonly Elements.Button submitButton =
            new Elements.Button(By.XPath("//button[@id='submit']"), "submitButton");


        public void ClickCardElements()
        {
            cardElements.WaitElement();
            cardElements.ClickElement();
        }

        public void ClickWebTables()
        {
            selectWebTables.ClickElement();
        }

        public bool IsTableDisplayed()
        {
            return table.IsDisplayedElement();
        }

        public void ClickAddButton()
        {
            addButton.ClickElement();
        }

        public bool IsRegFormDisplayed()
        {
            return registrForm.IsDisplayedElement();
        }

        public void EnterDataUser()
        {
            firstName.SendText(BaseTest.testModel.FirstName);
            lastName.SendText(BaseTest.testModel.LastName);
            userEmail.SendText(BaseTest.testModel.Email);
            age.SendText(BaseTest.testModel.Age);
            salary.SendText(BaseTest.testModel.Salary);
            department.SendText(BaseTest.testModel.Department);
        }

        public void SubmitButtonClick()
        {
            submitButton.ClickElement();
        }
    }
}
