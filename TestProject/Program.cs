using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();

        [Test]
       public static void Main(string[] args)
        {
           
            driver.Url = "http://test.spiders.pro/user";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("email")).SendKeys("subfeels@gmail.com");
                driver.FindElement(By.Id("password")).SendKeys("73512365");
                driver.FindElement(By.Id("login")).Click();
           
        }
    }
}
