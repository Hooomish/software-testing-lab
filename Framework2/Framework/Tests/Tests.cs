using NUnit.Framework;

namespace Framework.Tests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Clean_Up()
        {
            steps.CloseBrowser();
        }

        [TestCase]
        public void EnterCities()
        {
            bool actual = steps.EnterCities("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void ChangeLanguage()
        {
            bool actual = steps.ChangeLanguage();
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void SelectOneWay()
        {
            bool actual = steps.SelectOneWay();
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void SelectOneWayAndEnterCitiesWithMistakes()
        {
            bool actual = steps.SelectOneWayAndEnterCitiesWithMistakes("Минск");
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void SelectOneWayAndEnterCitiesWithoutMistakes()
        {
            bool actual = steps.SelectOneWayAndEnterCitiesWithoutMistakes("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void Reset()
        {
            bool actual = steps.Reset("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void ClickCombinedRoute()
        {
            bool actual = steps.ClickCombinedRoute();
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void ClickAdditionalOptions()
        {
            bool actual = steps.ClickAdditionalOptions();
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void ClickFilter()
        {
            bool actual = steps.ClickFilter("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }

        [TestCase]
        public void ShowDetailing()
        {
            bool actual = steps.ShowDetailing("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }
    }
}
