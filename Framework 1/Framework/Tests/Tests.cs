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
        public void Test1()
        {
            bool actual = steps.EnterCities("Минск", "Москва");
            Assert.AreEqual(true, actual);
        }
    }
}
