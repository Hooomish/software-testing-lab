using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_WebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
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
            }
            catch (NoSuchElementException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
