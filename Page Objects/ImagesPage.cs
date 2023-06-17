using OpenQA.Selenium;
using POM_Example.Helper_Functions;

namespace POM_Example.Page_Objects
{
    public class ImagesPage
    {

        private IWebDriver driver;

        private Helper_Functions.UtilityFunctions utilityFunctions;

        //Define the required element paths
        By imageSearchButton = By.CssSelector("[jsname='Tg7LZd']");
      

        public ImagesPage(IWebDriver driver, UtilityFunctions utilityFunctions)
        {
            this.driver = driver;
            this.utilityFunctions = utilityFunctions;

        }

        //Method to click the image search button
        public void searchImage()
        {
            utilityFunctions.waitForElementToBeClickable(imageSearchButton, 5);
            driver.FindElement(imageSearchButton).Click();
        }

       


    }
}
