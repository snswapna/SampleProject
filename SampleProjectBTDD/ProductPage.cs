using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProjectBTDD
{
    public class ProductPage
    {
        public IWebDriver driver { get; set; }
        private Process _iisProcess;


        public ProductPage()
        {
            //StartIIS();
            driver = new InternetExplorerDriver(@"C:\");
            
        }

        public void NavigateToProducts()
        {
            driver.Navigate().GoToUrl("http://localhost:56230/products/products");
        }

        public string DropDownExists()
        {
            return driver.FindElement(By.Id("ddState")).ToString();
        }

        public void DropDownClick()
        {
            driver.FindElement(By.Id("ddState")).Click();
        }

        public void DropDownValuesExists()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("ddState")));
             dropdown.SelectByIndex(1);

        }

        private void StartIIS()
        {
            //var applicationPath = GetApplicationPath(_applicationName);
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            _iisProcess = new Process();
            _iisProcess.StartInfo.FileName = programFiles + @"\IIS Express\iisexpress.exe";
            _iisProcess.StartInfo.Arguments = string.Format("http://localhost:56230/products/products");
            _iisProcess.Start();
        }
    }
}