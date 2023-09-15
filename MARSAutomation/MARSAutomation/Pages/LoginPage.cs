using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAutomation.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Find the SignIn Button

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

            Thread.Sleep(2000);
            //Enter the Login Details

            //driver.SwitchTo().Frame(0);

            IWebElement emailTextBox = driver.FindElement(By.Name("email"));
            emailTextBox.SendKeys("jananigcecse@gmail.com");

            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            passwordTextBox.SendKeys("Arjunajay@123");

            //Click on Login Button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

            Thread.Sleep(3000);

            //driver.SwitchTo().DefaultContent();

        }
    }
}
