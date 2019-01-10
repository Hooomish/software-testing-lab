using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://www.aviaru.de/ru/";

        [FindsBy(How = How.XPath, Using = "//*[@id='depapt1_name']")]
        private IWebElement cityFrom;

        [FindsBy(How = How.XPath, Using = "//*[@id='dstapt1_name")]
        private IWebElement cityTo;

        [FindsBy(How = How.XPath, Using = "//*[@id='depdate_add_day']/span")]
        private IWebElement date;

        [FindsBy(How = How.XPath, Using = "//*[@id='search_btn']")]
        private IWebElement search;
        
        private string frame = "ypsnet-ibe-iframe";

        private string attributeSrc = "src";

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            var urlForPanelElement = driver.FindElement(By.Name(frame));

            driver.Url = urlForPanelElement.GetAttribute(attributeSrc);
        }

        public void EnterCityFrom(string departureCity)
        {
            cityFrom.SendKeys(departureCity);
        }

        public void EnterCityTo(string arrivalCity)
        {
            cityTo.SendKeys(arrivalCity);
        }

        public void SearchClick()
        {
            search.Click();
        }

        public void ChangeDateClick()
        {
            date.Click();
        }
    }
}
