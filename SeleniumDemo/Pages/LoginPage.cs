using System;
using OpenQA.Selenium;

namespace SeleniumDemo.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement usernameTxt => Driver.FindElement(By.Id("UserName"));
        IWebElement passwordTxt => Driver.FindElement(By.Id("Password"));
        IWebElement loginBtn => Driver.FindElement(By.XPath("//input[@value='Log in']"));


        public void EnterUsernameAndPassword(string username, string password)
        {
            usernameTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
        }

        public void ClickLogin()
        {
            loginBtn.Click();
        }
    }
}
