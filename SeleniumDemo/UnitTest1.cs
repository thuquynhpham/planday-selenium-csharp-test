using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver("/Users/thuquynhpham/Projects/SeleniumDemo/SeleniumDemo/Driver");
            Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            string comboboxContrlName = "AllMealsCombo";
            CustomControl.ComboBox(comboboxContrlName, "Almond");

            Console.WriteLine("Test1");
            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            //driver.Quit();
        }
    }
}