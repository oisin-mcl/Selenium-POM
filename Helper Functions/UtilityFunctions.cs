using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POM_Example.Helper_Functions
{
    public class UtilityFunctions
    {

        private IWebDriver driver;

        public UtilityFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Method to wait for element to be clickable
        public void waitForElementToBeClickable(By element, int waitTime)
        {
            TimeSpan timout = TimeSpan.FromSeconds(waitTime);
            WebDriverWait wait = new WebDriverWait(driver, timout);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

    }
}
