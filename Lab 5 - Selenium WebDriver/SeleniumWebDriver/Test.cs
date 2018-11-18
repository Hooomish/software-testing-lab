using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod()
        {
            bool actual;

            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://www.aviaru.de/ru/";

                var urlForPanelElement = driver.FindElement(By.Name("ypsnet-ibe-iframe"));

                driver.Url = urlForPanelElement.GetAttribute("src");

                driver.FindElement(By.XPath(@"//*[@id='depapt1_name']")).SendKeys("Минск");
                driver.FindElement(By.XPath(@"//*[@id='dstapt1_name']")).SendKeys("Москва");
                driver.FindElement(By.XPath("//*[@id='depdate_add_day']/span")).Click();
                driver.FindElement(By.XPath(@"//*[@id='search_btn']")).Click();

                actual = true;
            }
            catch (Exception)
            {
                actual = false;
            }

            Assert.AreEqual(true, actual);
        }
    }
}
