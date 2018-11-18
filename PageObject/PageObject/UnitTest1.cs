using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObject
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver Driver;

        [TestInitialize]
        public void TestMethod()
        {
            Driver = new ChromeDriver();
        }

        [TestCleanup]
        public void SetupTest()
        {
            Driver.Quit();
        }

        [TestMethod]
        public void SearchTicketWithoutAgreement()
        {
            Aviaru aviaru = new Aviaru(Driver);
            aviaru.ValidateReult();
        }
    }
}
