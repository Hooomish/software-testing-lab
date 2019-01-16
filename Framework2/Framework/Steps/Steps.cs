using OpenQA.Selenium;
using System;
using System.Threading;
using System.Diagnostics;

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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChangeLanguage()
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                //mainPage.ChangeLanguage();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SelectOneWay()
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SelectOneWayAndEnterCitiesWithMistakes(string city_from)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();
                mainPage.EnterCityFrom(city_from);
                mainPage.ChangeDateClick();
                mainPage.SearchClick();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SelectOneWayAndEnterCitiesWithoutMistakes(string city_from, string city_to)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();
                mainPage.EnterCityFrom(city_from);
                mainPage.EnterCityTo(city_to);
                mainPage.ChangeDateClick();
                mainPage.SelectTime();
                mainPage.SearchClick();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Reset(string city_from, string city_to)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();
                mainPage.EnterCityFrom(city_from);
                mainPage.EnterCityTo(city_to);
                mainPage.ChangeDateClick();
                mainPage.SelectTime();
                mainPage.Reset();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClickCombinedRoute()
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.ClickCombinedRoute();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClickAdditionalOptions()
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.ClickAdditionalOptions();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClickFilter(string city_from, string city_to)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();
                mainPage.EnterCityFrom(city_from);
                mainPage.EnterCityTo(city_to);
                mainPage.ChangeDateClick();
                mainPage.SelectTime();
                mainPage.SearchClick();
                Thread.Sleep(5000);
                mainPage.ClickFilter();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ShowDetailing(string city_from, string city_to)
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.SelectOneWay();
                mainPage.EnterCityFrom(city_from);
                mainPage.EnterCityTo(city_to);
                mainPage.ChangeDateClick();
                mainPage.SelectTime();
                mainPage.SearchClick();
                //Thread.Sleep(5000);
                mainPage.LowPrices();

                return true;
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                Console.Write("axsdfds");
                Debug.Write("Target Invocation Exception appeared in ShowDetailing()");
                return false;
            }
        }
    }
}
