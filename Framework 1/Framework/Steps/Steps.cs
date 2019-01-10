using OpenQA.Selenium;
using System;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public bool EnterCities(string city_from, string city_to)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.EnterCityFrom(city_from);
                mainPage.EnterCityTo(city_to);
                mainPage.ChangeDateClick();
                mainPage.SearchClick();

                return true;
            }
            catch(Exception)
            {
                return false;
            }               
        }
    }
}
