using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDemo.Pages;

namespace SeleniumDemo
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver("/Users/thuquynhpham/Projects/SeleniumDemo/SeleniumDemo/Driver");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            string comboboxContrlName = "AllMealsCombo";
            CustomControl.ComboBox(comboboxContrlName, "Almond");

            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUsernameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.isLogoffExist(), Is.True, "Logoff button doesn't exist");

        }

        [TearDown]
        public void Teardown()
        {
            //driver.Quit();
        }
    }
}