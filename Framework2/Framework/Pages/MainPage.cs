using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://www.aviaru.de/ru/";

        [FindsBy(How = How.XPath, Using = "//*[@id='depapt1_name']")]
        private IWebElement cityFrom;

        [FindsBy(How = How.XPath, Using = "//*[@id='dstapt1_name']")]
        private IWebElement cityTo;

        [FindsBy(How = How.XPath, Using = "//*[@id='depdate_add_day']/span")]
        private IWebElement date;

        [FindsBy(How = How.XPath, Using = "//*[@id='search_btn']")]
        private IWebElement search;

        [FindsBy(How = How.XPath, Using = "//*[@id='oneway']")]
        private IWebElement oneWay;

        [FindsBy(How = How.XPath, Using = "//*[@id='lang_select']/div/button")]
        private IWebElement langSelect;

        [FindsBy(How = How.XPath, Using = "//*[@id='lang_select']/div/ul/li[1]/a")]
        private IWebElement english;

        [FindsBy(How = How.XPath, Using = "//*[@id='deptime_latest']/option[25]")]
        private IWebElement timeBefore;

        [FindsBy(How = How.XPath, Using = "//*[@id='deptime_earliest']/option[4]")]
        private IWebElement timeAfter;

        [FindsBy(How = How.XPath, Using = "//*[@id='tarif_1612444927']/div/div[3]/div[4]/button[2]")]
        private IWebElement checkout;

        [FindsBy(How = How.XPath, Using = "//*[@id='openjaw']")]
        private IWebElement combinedRoute;

        [FindsBy(How = How.XPath, Using = "//*[@id='form_normal']/div[5]/div[1]/a")]
        private IWebElement additionalOptions;

        [FindsBy(How = How.XPath, Using = "//*[@id='filter_nonstop']")]
        private IWebElement filter;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabs_container']/div/ul/li[2]")]
        private IWebElement lowPrices;

        [FindsBy(How = How.XPath, Using = "//*[@id='reset-selections']/a")]
        private IWebElement reset;

        private string frame = "ypsnet-ibe-iframe";

        private string attributeSrc = "src";

        private string attributeHref = "href";

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

        public void ChangeLanguage(string lang)
        {
            langSelect.Click();
            //driver.findElement(string.Format(LANG_XPATH), lang).click;//a/img[contains(text(), "English")]
        }

        public void SelectOneWay()
        {
            oneWay.Click();
        }

        public void SelectTime()
        {
            timeBefore.Click();
            timeAfter.Click();
        }

        public void ClickCheckout()
        {
            checkout.Click();
        }

        public void ClickCombinedRoute()
        {
            combinedRoute.Click();
        }

        public void ClickAdditionalOptions()
        {
            additionalOptions.Click();
        }

        public void ClickFilter()
        {
            filter.Click();
        }

        public void LowPrices()
        {
            lowPrices.Click();
        }

        public void Reset()
        {
            driver.Url = reset.GetAttribute(attributeHref);
        }
    }
}
