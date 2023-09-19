using MARSAutomation.Pages;
using MARSAutomation.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Reflection.Emit;

namespace MARSAutomation.StepDefinitions
{
    [Binding]
    

    public class ProfileStepDefinitions : CommonDriver

    {
        [BeforeScenario] 
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        ProfilePage profilePageObj = new ProfilePage();
        LoginPage loginPageObj = new LoginPage();

        [Given(@"I logged into the MARS Application successfully")]
        public void GivenILoggedIntoTheMARSApplicationSuccessfully()
        {
            
            
            loginPageObj.LoginActions (driver);
        }

        [Given(@"I navigate to Profile Page")]
        public void GivenINavigateToProfilePage()
        {
            
            String userName = profilePageObj.VerifyUser(driver);
            Assert.That(userName == "Hi Janani1", "User not logged in Successfully");
            
        }

        [When(@"I Add a new Language '([^']*)' '([^']*)'")]
        public void WhenIAddANewLanguage(string language, string level)
        {
           
            profilePageObj.AddLanguages(driver, language, level);
        }



        [Then(@"the language should be added Successfully '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeAddedSuccessfully(string language, string level)
        {
            
            string langName = profilePageObj.VerifyLanguage(driver);
            string langLevel = profilePageObj.VerifyLanguageLevel(driver);
            Assert.That(langName == language, "Language not added successfully");
            Assert.That(langLevel == level, "Language level not added Successfully");

        }
        [When(@"I Add a Language that already exists '([^']*)' '([^']*)'")]
        public void WhenIAddALanguageThatAlreadyExists(string language, string level)
        {
           
            profilePageObj.AddLanguages(driver, language, level);

        }

        [Then(@"the Language should not be added")]
        public void ThenTheLanguageShouldNotBeAdded()
        {
           
            string actualMessage = profilePageObj.alertMessage(driver);
            string expectedMessage = "Duplicated data";
            Assert.That(actualMessage == expectedMessage, "Duplicate data added");

        }

        [When(@"I Add a new Language with invalid input '([^']*)' '([^']*)'")]
        public void WhenIAddANewLanguageWithInvalidInput(string language, string level)
        {
           
            profilePageObj.AddLanguages(driver, language, level);
        }

        [Then(@"the user should see an error message")]
        public void ThenTheUserShouldSeeAnErrorMessage()
        {
            
            string actualMessage = profilePageObj.alertMessage(driver);
            string expectedMessage = "Please enter language and level";
            Assert.That(actualMessage == expectedMessage, "Invalid data added");
        }



        [Given(@"I Add a new Language")]
        public void GivenIAddANewLanguage()
        {
            string language = "Mandarin";
            string level = "Basic";
            
            profilePageObj.AddLanguages(driver, language, level);
        }

        [When(@"I Update the Language '([^']*)' '([^']*)'")]
        public void WhenIUpdateTheLanguage(string language, string level)
        {
           
            profilePageObj.UpdateLanguage(driver, language, level);
        }


        [Then(@"the language should be updated successfully '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeUpdatedSuccessfully(string language, string level)
        {
           
            string langName = profilePageObj.VerifyLanguage(driver);
            string langLevel = profilePageObj.VerifyLanguageLevel(driver);
            Assert.That(langName == language, "Language not Updated");
            Assert.That(langLevel == level, "Language level not Updated Successfully");
        }

        [Given(@"I Add a new Language '([^']*)' '([^']*)'")]
        public void GivenIAddANewLanguage(string language, string level)
        {
           
            profilePageObj.AddLanguages(driver, language, level);
        }

        [When(@"I Delete the Language")]
        public void WhenIDeleteTheLanguage()
        {
         
            profilePageObj.DeleteLanguage(driver);
        }

        [Then(@"the language should be deleted successfully '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeDeletedSuccessfully(string language, string level)
        {
           
            string langName = profilePageObj.VerifyLanguage(driver);
            Assert.That(langName != language, "Language not Deleted");
          
        }
        [When(@"I Add a new Skill '([^']*)''([^']*)'")]
        public void WhenIAddANewSkill(string skill, string level)
        {

           
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.AddSkills(driver, skill, level);
        }

        [Then(@"the Skill should be added successfully '([^']*)''([^']*)'")]
        public void ThenTheSkillShouldBeAddedSuccessfully(string skill, string level)
        {
            
           string skillName =  profilePageObj.VerifySkill(driver);
            string skillLevel = profilePageObj.verifySkillLevel(driver);
            Assert.That(skillName == skill, "Skill not added successfully");
            Assert.That(skillLevel == level, "Skill level not added successfully");

        }
        [When(@"I Add a Skill that already exists '([^']*)' '([^']*)'")]
        public void WhenIAddASkillThatAlreadyExists(string skill, string level)
        {
           
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.AddSkills(driver, skill, level);
        }

        [Then(@"the Skill should not be added")]
        public void ThenTheSkillShouldNotBeAdded()
        {
           
            string actualMessage = profilePageObj.alertMessage(driver);
            string expectedMessage = "Duplicated data";
            Assert.That(actualMessage == expectedMessage, "Duplicate data added");
        }
        [When(@"I Add a new Skill with invalid input '([^']*)' '([^']*)'")]
        public void WhenIAddANewSkillWithInvalidInput(string skill, string level)
        {
           
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.AddSkills(driver, skill, level);
        }

        [Then(@"the user should see an error message to enter Skill")]
        public void ThenTheUserShouldSeeAnErrorMessageToEnterSkill()
        {
           
            string actualMessage = profilePageObj.alertMessage(driver);
            string expectedMessage = "Please enter skill and experience level";
            Assert.That(actualMessage == expectedMessage, "Invalid data added");
        }
        [When(@"I Update a Skill '([^']*)' '([^']*)'")]
        public void WhenIUpdateASkill(string skill, string level)
        {
            string skillNew = "Dancing";
            string levelNew = "Expert";
          
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.AddSkills(driver, skillNew, levelNew);
            profilePageObj.UpdateSkill(driver, skill, level);


        }

        [Then(@"the Skill should be updated successfully '([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldBeUpdatedSuccessfully(string skill, string level)
        {
           
            string skillName = profilePageObj.VerifySkill(driver);
            string skillLevel = profilePageObj.verifySkillLevel(driver);
            Assert.That(skillName == skill, "Skill not added successfully");
            Assert.That(skillLevel == level, "Skill level not added successfully");

        }
        [Given(@"I Add a new Skill '([^']*)' '([^']*)'")]
        public void GivenIAddANewSkill(string skill, string level)
        {
          
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.AddSkills(driver, skill, level);
        }

        [When(@"I Delete the Skill")]
        public void WhenIDeleteTheSkill()
        {
          
            profilePageObj.DeleteSkill(driver);

        }

        [Then(@"the Skill should be deleted successfully '([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldBeDeletedSuccessfully(string skill, string level)
        {
           
            string skillName = profilePageObj.VerifySkill(driver);
            Assert.That(skillName != skill, "Skill not deleted");
        }

        [When(@"I Cancel Adding a language '([^']*)' '([^']*)'")]
        public void WhenICancelAddingALanguage(string language, string skill)
        {
            profilePageObj.CancelAddLanguages(driver, language, skill);
        }

        [Then(@"the Language should not be added '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldNotBeAdded(string language, string level)
        {
            string langName = profilePageObj.VerifyLanguage(driver);
            Assert.That(langName != language, "Language Added");
        }

        [When(@"I Cancel Adding a Skill '([^']*)' '([^']*)'")]
        public void WhenICancelAddingASkill(string skill, string level)
        {
            profilePageObj.GoToSkillsTab(driver);
            profilePageObj.CancelAddSkills(driver, skill, level);
        }

        [Then(@"the Skill should not be added '([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldNotBeAdded(string skill, string level)
        {
            string skillName = profilePageObj.VerifySkill(driver);
            Assert.That(skillName != skill, "Skill Added");
        }


        [TearDown]
        public void CloseDriver(IWebDriver driver)
        {
            driver.Quit();
        }



    }

}
