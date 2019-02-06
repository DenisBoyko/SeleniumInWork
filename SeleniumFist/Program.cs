using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFist
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }
        
        [SetUp]
        public void Open()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement elementFaq = driver.FindElement(By.CssSelector("[href='https://rozetka.com.ua/faq/']"));
            Thread.Sleep(3000);
            elementFaq.Click();
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
        

    }
}

