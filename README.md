# Selenium-POM-Example

This project is a basic framework designed in C# using Selenium, to showcase how to begin designing and implementing UI Automation.

For this short example, I designed 3 test cases within Selenium, using NUnit to test some search capabilites within Google as a showcase of how this works at a high level. The same approach would be taken in large test projects, by scaling up but keeping the core concepts in place.

This approach uses a design pattern known as Page Object Model, or POM, as a way of encapsulating off code into classes, and adhering to the SOLID and DRY principles where possible. With this pattern, we structure the classes into a tree shown below:

![image](https://github.com/oisin-mcl/Selenium-POM-Example/assets/56615317/f6fcb551-3322-457f-8464-ebc0f5cd3096)

With this, there are 3 main folders;
  - Helper Functions: This folder holds the "UtilityFunctions" class, that stores off the common non page specific code, such as custom wait methods etc.
  - Page Objects: This folder holds our Page specific code arranged in classes. Each page has its own Page Object class. This is where we locate any elements on a page, any methods relating to those elements etc.
  - Tests: This holds our test cases.

 Lets look at some sample code stored in the "UtilityFunctions" class.

 ![image](https://github.com/oisin-mcl/Selenium-POM-Example/assets/56615317/b3eb782b-0c2e-43ba-a4b6-ceb2e435cdba)

Again, this class will hold any code that is not specific to any one page, but rather code that is needed to help out the tests overall. This is where I have defined a custom wait method that can now be called from any Page Object or Test that requires it.

Now lets look at a Page Object class.

![image](https://github.com/oisin-mcl/Selenium-POM-Example/assets/56615317/9b9ac625-75ff-47c2-9490-50a465ed05ac)

Here, we first create an instance of the UtilityFunctions class to get the helper methods we need. We also define the element locators that are relevant to this page, in this case the Google home page.
Once we have gotten those, we can see the methods for performing actions on this page, using the above elements. The one shown above will select "reject" on the cookie popup that appears on new instances of Google. We can see that the method just gets the popup, and clicks the button. Simple!

Lastly, lets look at a test.

![image](https://github.com/oisin-mcl/Selenium-POM-Example/assets/56615317/dc8cddd8-2d0a-449e-bbc5-13ed7a9006f2)

In the test, we have again created instances of the UtilityFunctions class, and also of the page object we need too. This means we can call any method or element from those that we wish.

As we can also see, this uses NUnit, as stated above. So, we split the test into 3 areas, using NUnit Attributes; Setup, Test and TearDown. There are lots more we can use, but for this basic exmaple, lets stick to these 3.

The Setup method will cover any pre-req steps that are necessary before the test begins. This would be navigating to URLs, opening any pages, loading any test data etc. In this case, it is simply to open Google, and maximise the window.

Next, we define the Test method. In here, we chain together the Page Object methods in the order we wish to run them, passing in the search term into the "getSearchBar" method call.

Lastly, the TearDown method. This will be clean up after the test, where we should be aiming to clear the test and leave it in the same state as before the test begins.

Following these simple setup steps, we can finally run the tests. When right clicking on the "Tests" folder > select Run Tests.

Following the completion, you will be able to see the results as shown here:
![image](https://github.com/oisin-mcl/Selenium-POM-Example/assets/56615317/c3947316-3db1-4516-8013-1d350eb02f21)

This is a very basic example to highlight how we should organise and structure our test cases in Selenium. Even in these brief examples we can see that this test is independant, easily understood and very maintainable; 3 of the most important pillars of automation. This can be further improved by removing the serialization nature of these tests, and implementing NUnit parallel threads etc.
