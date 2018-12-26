using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject
{
    class TestRunLogin
    {
  
       public static void Main(string[] args)
        {
            int UserAge = 18;
            if (UserAge > 18)
            {
                Console.WriteLine("Ti uze vzrosliy");
                string Password = Console.ReadLine();

                if (Password == "12345")
                {
                    Console.WriteLine("PAssword is entered");
                }
            }

        }
        

    }
}
