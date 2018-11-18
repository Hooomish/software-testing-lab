using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    [TestClass]
    class Aviaru
    {
        IWebDriver driver;

        public Aviaru(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Manage().Window.Maximize();
            PageFactory.InitElements(driver, this);
        }

        bool ClickElement()
        {
            try
            {
                driver.Url = "https://www.aviaru.de/ru/";

                var urlForPanelElement = driver.FindElement(By.Name("ypsnet-ibe-iframe"));

                driver.Url = urlForPanelElement.GetAttribute("src");

                driver.FindElement(By.XPath(@"//*[@id='depapt1_name']")).SendKeys("Минск");
                driver.FindElement(By.XPath(@"//*[@id='dstapt1_name']")).SendKeys("Москва");
                driver.FindElement(By.XPath("//*[@id='depdate_add_day']/span")).Click();
                driver.FindElement(By.XPath(@"//*[@id='search_btn']")).Click();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void ValidateReult()
        {
            Assert.AreEqual(true, ClickElement());
        }
    }
}
