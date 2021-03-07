using System;
using OpenQA.Selenium;

namespace SeleniumDemo.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement linkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement linkLogoff => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => linkLogin.Click();
        public bool isLogoffExist() => linkLogoff.Displayed;

    }
}
