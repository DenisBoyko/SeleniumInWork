
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFist
{
    class Tests
    {
        IWebDriver driver = new ChromeDriver();
        SeleniumSetMethods seleniumSetMethods = new SeleniumSetMethods();
        MainPageObject mainPage = new MainPageObject();
        TourPageObject tourPageObject = new TourPageObject();

        [SetUp]
        public void OpenBrowser()
        {
            seleniumSetMethods.OpenBrowser(driver,mainPage.Url);
        }
        

        [Test]
        public void ExecuteTest()
        {
            seleniumSetMethods.Click(driver, mainPage.tourButton,"CssSelector", 3000);
            Assert.AreEqual(seleniumSetMethods.GetText(driver, tourPageObject.assertPohodButton), "ПОХОД ПО КИПРУ");

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }




    }
}

