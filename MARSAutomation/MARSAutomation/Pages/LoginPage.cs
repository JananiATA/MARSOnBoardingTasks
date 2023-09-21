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
        
       
        By signIn = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        By emailMARS = By.Name("email");
        By passwordMARS = By.Name("password");
        By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void ClickSignIn()
        {

            driver.FindElement(signIn).Click();

        }

        //Set emailId in textbox
        public void SetEmailId(string emailId)
        {
            driver.FindElement(emailMARS).SendKeys(emailId);

        }

        //Set password in textbox
        public void SetPassword(String password)
        {

            driver.FindElement(passwordMARS).SendKeys(password);


        }
        public void ClickLogin()
        {

            driver.FindElement(loginButton).Click();

        }
        public void LoginActions(String emailId, String password)
        {
           
            //Click Signin button
            this.ClickSignIn();

            //Fill user name

            this.SetEmailId(emailId);

            //Fill password

            this.SetPassword(password);

            //Click Login button

            this.ClickLogin();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
        }
    }
}
