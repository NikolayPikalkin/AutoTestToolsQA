using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ToolsQA.ConfigData;
using ToolsQA.TestData;
using ToolsQA.Utils;

namespace ToolsQA
{
    public class BaseTest
    {
        public static ConfigModel configModel;
        public static TestDataModel testModel;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            InitializeData();
        }
        private void InitializeData()
        {
            BaseDirectory.FindDirectory();

            ConfigDataReader.ConfDataRead(out ConfigModel configModelObject);
            configModel = configModelObject;

            TestDataReader.TestDataRead(out TestDataModel testModelObject);
            testModel = testModelObject;
        }
        [SetUp]
        protected void DoBeforeEach()
        {
            ActionsBrowser.SettingSize(configModel.Width,configModel.Height);
        }

        [TearDown]
        protected void DoAfterEach()
        {
            InitWebDriver.QuitDriver();
        }

    }
}
