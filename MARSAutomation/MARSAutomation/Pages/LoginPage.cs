using MARSAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MARSAutomation.Pages
{
    public class LoginPage : CommonDriver
    {

       private IWebElement signInButton => webDriver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
       private IWebElement emailMARS => webDriver.FindElement(By.Name("email"));
       private IWebElement passwordMARS => webDriver.FindElement(By.Name("password"));
       private IWebElement loginButton => webDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

       private IWebDriver webDriver;

        /* By signIn = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        By emailMARS = By.Name("email");
        By passwordMARS = By.Name("password");
        By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"); */
        public LoginPage(IWebDriver driver)
        {
          
               webDriver  = driver;

        } 
        public void ClickSignIn()
        {

            signInButton.Click();

        }

        //Set emailId in textbox
        public void SetEmailId(string emailId)
        {
            emailMARS.SendKeys(emailId);

        }

        //Set password in textbox
        public void SetPassword(String password)
        {

            passwordMARS.SendKeys(password);


        }
        public void ClickLogin()
        {

            loginButton.Click();

        }
        public void LoginActions(IWebDriver driver,String emailId, String password)
        {
           
            //Click Signin button
            ClickSignIn();


            SetEmailId(emailId);

            //Fill password

            SetPassword(password);

            //Click Login button

            ClickLogin();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
        } 
    }
}
