﻿

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("QWRWR");

        Thread.Sleep(3000);
        textBox.Clear();
        Thread.Sleep(3000);



        driver.Quit();

    }
}
