using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumFist
{
    public class SeleniumSetMethods
    {
           
        public void OpenBrowser(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
        }
           

        public void EnterText(IWebDriver driver, string element, string textValue, string elementType)
        {
            if (elementType == "CssSelector")
            {
                driver.FindElement(By.CssSelector(element)).SendKeys(textValue);
            }

            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).SendKeys(textValue);
            }
        }

        public void Click (IWebDriver driver, string element, string elementType, int wait)
        {
            if (elementType == "CssSelector")
            {
                IWebElement newElement = driver.FindElement(By.CssSelector(element));
                Thread.Sleep(wait);
                newElement.Click();
            }

            if (elementType == "XPath")
            {
                IWebElement newElement = driver.FindElement(By.XPath(element));
                Thread.Sleep(wait);
                newElement.Click();
            }
        }

        public string GetText(IWebDriver driver, string element)
        {
            return driver.FindElement(By.CssSelector(element)).Text;
        }

        
    

    }
    
    
}
