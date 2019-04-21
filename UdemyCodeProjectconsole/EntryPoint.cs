

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using UdemyCodeProjectconsole;

class EntryPoint
{
    public static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;
    static IWebElement checkbox2;
    static IWebElement checkbox1;
    static IWebElement radioButton;
    static IWebElement dropDownMenu;
    static IWebElement element;

    public static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuelement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
        Console.WriteLine("The Selected value is : " + dropDownMenu.GetAttribute("value"));

        element = driver.FindElement(By.CssSelector(dropDownMenuelement));
        Console.WriteLine("The third option fro menu is : " + element.GetAttribute("value"));

        element.Click();
        Console.WriteLine("The Selected value is : " + dropDownMenu.GetAttribute("value"));

        for (int i = 1; i <= 4; i++)
        {
            dropDownMenuelement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            element = driver.FindElement(By.CssSelector(dropDownMenuelement));
            Console.WriteLine("The" + i +  "VALUE IS SELECTED : " + element.GetAttribute("value"));
        }
        
        
        Console.ReadLine();
        driver.Quit();

    }
}