using MARSAutomation.Pages;
using MARSAutomation.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MARSAutomation.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the MARS Application successfully")]
        public void GivenILoggedIntoTheMARSApplicationSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions (driver);
        }

        [Given(@"I navigate to Profile Page")]
        public void GivenINavigateToProfilePage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            String userName = profilePageObj.VerifyUser(driver);
            Assert.That(userName == "Hi Janani", "User not logged in Successfully");
            
        }

        [When(@"I Add a new Language '([^']*)' '([^']*)'")]
        public void WhenIAddANewLanguage(string language, string level)
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguages(driver, language);
        }



        [Then(@"the language should be added Successfully '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeAddedSuccessfully(string language, string level)
        {
            ProfilePage profilePageObj = new ProfilePage();
            string langName = profilePageObj.VerifyAddLanguage(driver);
            Console.WriteLine(langName);
            Assert.That(langName == language, "Language not added successfully");

        }

    }

}
