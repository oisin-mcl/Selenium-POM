using OpenQA.Selenium;
using POM_Example.Helper_Functions;

namespace POM_Example.Page_Objects
{
    public class HomePage
    {

        private IWebDriver driver;

        private Helper_Functions.UtilityFunctions utilityFunctions;

        //Define the required element paths
        By searchBar = By.CssSelector("[title='Search']");
        By popUp = By.Id("W0wltc");
        By searchButton = By.XPath("//input[@name='btnK'][1]"); 
        By imFeelingLuckyButton = By.XPath("//input[@name='btnI'][1]");
      

        public HomePage(IWebDriver driver, UtilityFunctions utilityFunctions)
        {
            this.driver = driver;
            this.utilityFunctions = utilityFunctions;

        }

        //Method to click Reject on the Google popup
        public void handleCookiePopup()
        {
            IWebElement cookiePopup = driver.FindElement(popUp);
            cookiePopup.Click();
        }

        //Method to get the search bar
        public void getSearchBar(String testData)
        {
            IWebElement search = driver.FindElement(searchBar);
            search.Click();
            search.SendKeys(testData);
        }

        //Method to click the search button
        public void selectSearch()
        {
            utilityFunctions.waitForElementToBeClickable(searchButton, 5);
            IWebElement search = driver.FindElement(searchButton);
            search.Click();

        }

        //Method to select "Im Feeling Lucky"
        public void selectImFeelingLucky()
        {
            utilityFunctions.waitForElementToBeClickable(imFeelingLuckyButton, 5);
            IWebElement lucky = driver.FindElement(imFeelingLuckyButton);
            lucky.Click();
        }



    }
}
