using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AlertBox
{
    class EntryPoint
    {
        public static IWebDriver driver = new ChromeDriver();
        static IAlert alert;
        static IWebElement image;

        static void Main(string[] args)
        {
            string url = "http://testing.todvachev.com/special-elements/alert-box/";
            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();
            alert.Accept();
            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

            try
            {
                if (image.Displayed)
                {
                    Console.WriteLine("The image is displayed");
                }
            }
            catch (NoSuchElementException)
            {
                    Console.WriteLine("I can't see the image");
            } 


            Console.ReadLine();
            driver.Quit();
        }


    }
}
