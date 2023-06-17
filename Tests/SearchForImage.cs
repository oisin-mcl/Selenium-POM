
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POM_Example.Tests
{
    public class SearchForImage
    {

        private IWebDriver driver;

        private Page_Objects.HomePage homePage;
        private Helper_Functions.UtilityFunctions utilityFunctions;
        private Page_Objects.ImagesPage imagesPage;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/imghp");
            driver.Manage().Window.Maximize();

            utilityFunctions = new Helper_Functions.UtilityFunctions(driver);
            homePage = new Page_Objects.HomePage(driver, utilityFunctions);
            imagesPage = new Page_Objects.ImagesPage(driver, utilityFunctions);

        }

        [Test]
        public void testSearch()
        {
            homePage.handleCookiePopup();
            homePage.getSearchBar("cat");
            imagesPage.searchImage();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        } 
    }
}
