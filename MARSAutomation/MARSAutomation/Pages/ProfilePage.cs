using MARSAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAutomation.Pages
{
    public class ProfilePage : CommonDriver
    {
        //Navigation between Languages and Skills tab

        By languageTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]");
        By skillTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void ClickLanguagesTab()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            driver.FindElement(languageTab).Click();

        }
        public void ClickSkillTab()
        {
            Wait.WaitToBeVisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            driver.FindElement(skillTab).Click();

        }
        public void GoToLanguageTab()
        {
            this.ClickLanguagesTab();
        }
        public void GoToSkillsTab()
        {
            this.ClickSkillTab();
        }

        //Add Language in Languages Tab
        
        By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        By languageTextBox = By.Name("name");
        By langLevelDropdown = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select");
        By langLevelBasic = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]");
        By langLevelConversational = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]");
        By langLevelFluent = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]");
        By langLevelBilingual = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]");
        By addButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");

        public void ClickAddNewButton()
        {

            driver.FindElement(addNewButton).Click();

        }

        
        public void AddLanguage(string language)
        {
            driver.FindElement(languageTextBox).SendKeys(language);

        }

        public void ClickLevelDropdown()
        {
            
            driver.FindElement(langLevelDropdown).Click();
        }

        
        public void AddLevelBasic()
        {

            driver.FindElement(langLevelBasic).Click();


        }
        public void AddLevelConversational()
        {

            driver.FindElement(langLevelConversational).Click();


        }
        public void AddLevelFluent()
        {

            driver.FindElement(langLevelFluent).Click();


        }
        public void AddLevelBilingual()
        {

            driver.FindElement(langLevelBilingual).Click();


        }
        public void ClickAddButton()
        {

            driver.FindElement(addButton).Click();

        }
        public void AddLanguage(String language, String level)
        {

            
            this.ClickAddNewButton();

            this.AddLanguage(language);

            this.ClickLevelDropdown();

            if (level == "Basic")
            {

                this.AddLevelBasic();
            }
            if (level == "Conversational")
            {
                this.AddLevelConversational();
            }
            if (level == "Fluent")
            {
                this.AddLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                this.AddLevelBilingual();
            }

            this.ClickAddButton();

            // Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        // Cancel Adding a language

        By cancelButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]");

        public void ClickCancelButton()
        {

            driver.FindElement(cancelButton).Click();

        }
        public void CancelAddLanguage(String language, String level)
        {

            
            this.ClickAddNewButton();

            this.AddLanguage(language);

            this.ClickLevelDropdown();

            if (level == "Basic")
            {

                this.AddLevelBasic();
            }
            if (level == "Conversational")
            {
                this.AddLevelConversational();
            }
            if (level == "Fluent")
            {
                this.AddLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                this.AddLevelBilingual();
            }

            this.ClickCancelButton();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Thread.Sleep(1000);
        }

        // Updating Language

        By editIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        By updateTextBox = By.Name("name");
        By updateLevelDropdown = By.Name("level");
        By updateLevelBasic = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]");
        By updateLevelConversational = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]");
        By updateLevelFluent = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]");
        By updateLevelBilingual = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]");
        By updateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");

        public void ClickEditIcon()
        {

            driver.FindElement(editIcon).Click();

        }

        
        public void AddNewLanguage(string language)
        {
            driver.FindElement(updateTextBox).Clear();
            driver.FindElement(updateTextBox).SendKeys(language);

        }

        public void ClickLanguageDropdown()
        {

            driver.FindElement(updateLevelDropdown).Click();
        }


        public void UpdateLevelBasic()
        {

            driver.FindElement(updateLevelBasic).Click();


        }
        public void UpdateLevelConversational()
        {

            driver.FindElement(updateLevelConversational).Click();


        }
        public void UpdateLevelFluent()
        {

            driver.FindElement(updateLevelFluent).Click();


        }
        public void UpdateLevelBilingual()
        {

            driver.FindElement(updateLevelBilingual).Click();


        }
        public void ClickEditButton()
        {

            driver.FindElement(updateButton).Click();

        }
        public void UpdateLanguage(String language, String level)
        {

            
            this.ClickEditIcon();

            this.AddNewLanguage(language);

            this.ClickLanguageDropdown();

            if (level == "Basic")
            {

                this.UpdateLevelBasic();
            }
            if (level == "Conversational")
            {
                this.UpdateLevelConversational();
            }
            if (level == "Fluent")
            {
                this.UpdateLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                this.UpdateLevelBilingual();
            }

            this.ClickEditButton();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);

        }
        
       // Delete Language
        
        By deleteIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");

        public void ClickDeleteIcon()
        {

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 5);
            driver.FindElement(deleteIcon).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            

        }
        public void DeleteLanguage()
        {
            this.ClickDeleteIcon();
        }

        

        By errorMessage = By.XPath("//*[@class='ns-box-inner']");
        By languageName = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By languageLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]");

        //Alert message Verification
        public string AlertMessage(IWebDriver driver)
          {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 5);
           
            return driver.FindElement(errorMessage).Text;
          }
         
        // Language Verification
        public string VerifyLanguage(IWebDriver driver)
        {

            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return driver.FindElement(languageName).Text;
        }

        //Language level Verification
        public string VerifyLanguageLevel(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            return driver.FindElement(languageLevel).Text;
        }

        // Add Skill in skills tab

        By addNewSkillButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        By skillTextBox = By.Name("name");
        By skillLevelDropdown = By.Name("level");
        By skillLevelBeginner = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]");
        By skillLevelintermediate = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]");
        By skillLevelExpert = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]");
        By addSkillButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");

        public void ClickAddNewSkill()
        {

            driver.FindElement(addNewSkillButton).Click();

        }


        public void EnterSkill(string skill)
        {
            driver.FindElement(skillTextBox).SendKeys(skill);

        }

        public void ClickSkillLevelDropdown()
        {

            driver.FindElement(skillLevelDropdown).Click();
        }


        public void AddLevelBeginner()
        {

            driver.FindElement(skillLevelBeginner).Click();


        }
        public void AddLevelIntermediate()
        {

            driver.FindElement(skillLevelintermediate).Click();


        }
        public void AddLevelExpert()
        {

            driver.FindElement(skillLevelExpert).Click();


        }
       
        public void ClickAddSkillButton()
        {

            driver.FindElement(addSkillButton).Click();

        }
        public void AddSkill(String skill, String level)
        {


            this.ClickAddNewSkill();

            this.EnterSkill(skill);

            this.ClickSkillLevelDropdown();

            if (level == "Beginner")
            {

                this.AddLevelBeginner();
            }
            if (level == "Intermediate")
            {
                this.AddLevelIntermediate();
            }
            if (level == "Expert")
            {
                this.AddLevelExpert();
            }
           
            this.ClickAddSkillButton();

            Thread.Sleep(1000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        //Cancel Adding Skill

        By cancelSkillButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]");

        public void ClickCancelSkillButton()
        {

            driver.FindElement(cancelSkillButton).Click();

        }
        public void CancelAddSkill(String skill, String level)
        {


            this.ClickAddNewSkill();

            this.EnterSkill(skill);

            this.ClickSkillLevelDropdown();

            if (level == "Beginner")
            {

                this.AddLevelBeginner();
            }
            if (level == "Intermediate")
            {
                this.AddLevelIntermediate();
            }
            if (level == "Expert")
            {
                this.AddLevelExpert();
            }

            this.ClickCancelSkillButton();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }



        // Verification of Skill and Level

        By skillNameVerify = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]");
        By skillLevel = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]");

        public string VerifySkill(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          
            return driver.FindElement(skillNameVerify).Text;
        }
        public string VerifySkillLevel(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            return driver.FindElement(skillLevel).Text;
        }


        // Update Skill

        By updateSkillIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
        By updateSkillTextBox = By.Name("name");
        By updateSkillLevelDropdown = By.Name("level");
        By updateSkillBeginner = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]");
        By updateSkillIntermediate = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]");
        By updateSkillExpert = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]");
        By updateSkillButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
        public void ClickUpdateSkill()
        {

            driver.FindElement(updateSkillIcon).Click();

        }


        public void EnterNewSkill(string skill)
        {
            driver.FindElement(updateSkillTextBox).Clear();
            driver.FindElement(updateSkillTextBox).SendKeys(skill);

        }

        public void UpdateSkillLevelDropdown()
        {

            driver.FindElement(updateSkillLevelDropdown).Click();
        }


        public void UpdateLevelBeginner()
        {

            driver.FindElement(updateSkillBeginner).Click();


        }
        public void UpdateLevelIntermediate()
        {

            driver.FindElement(updateSkillIntermediate).Click();


        }
        public void UpdateLevelExpert()
        {

            driver.FindElement(updateSkillExpert).Click();


        }

        public void ClickUpdateSkillButton()
        {

            driver.FindElement(updateSkillButton).Click();

        }
        public void UpdateSkill(String skill, String level)
        {


            this.ClickUpdateSkill();

            this.EnterNewSkill(skill);

            this.UpdateSkillLevelDropdown();

            if (level == "Beginner")
            {

                this.UpdateLevelBeginner();
            }
            if (level == "Intermediate")
            {
                this.UpdateLevelIntermediate();
            }
            if (level == "Expert")
            {
                this.UpdateLevelExpert();
            }

            this.ClickUpdateSkillButton();

            Thread.Sleep(1000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        //Delete Skill

        By deleteSkillIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");

        public void ClickDeleteSkillIcon()
        {

            driver.FindElement(deleteSkillIcon).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);

        }
        public void DeleteSkill()
        {
            this.ClickDeleteSkillIcon();
        }
        
    } 
}