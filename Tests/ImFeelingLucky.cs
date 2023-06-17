
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POM_Example.Tests
{
    public class ImFeelingLucky
    {

        private IWebDriver driver;

        private Page_Objects.HomePage homePage;
        private Helper_Functions.UtilityFunctions utilityFunctions;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

            utilityFunctions = new Helper_Functions.UtilityFunctions(driver);
            homePage = new Page_Objects.HomePage(driver, utilityFunctions);

        }

        [Test]
        public void testSearch()
        {
            homePage.handleCookiePopup();
            homePage.getSearchBar("github");
            homePage.selectImFeelingLucky();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        } 
    }
}
