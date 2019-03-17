using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyCodeProjectconsole
{
    class TestRadioButton
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radioButton;


        public static void TestingOfRadioButton()
        {
            string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
            driver.Navigate().GoToUrl(url);
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(1)"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("this radiobutton is checked");
            }
            else
            {
                Console.WriteLine("this radiobutton is NOT checked");
            }

            Thread.Sleep(1000);
            Console.ReadLine();

            driver.Quit();
        }

      


    }
}
