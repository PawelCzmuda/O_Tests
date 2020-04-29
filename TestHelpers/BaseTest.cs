using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;


namespace Omada_AutomatedTests
{
    public abstract class BaseTest
    {
        public static IWebDriver driver;
        public static void BaseClassInitialize()
        {
            CreateDriver();
        }

        private static void CreateDriver()
        {

            string browser = "Chrome";


            if (browser == null)
            {
                throw new InvalidOperationException("No Browser attribute is specified. ");
            }

            else
            {
                switch (browser)
                {
                    case "Chrome":
                        driver = new ChromeDriver();
                        break;
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                    default:
                        throw new InvalidOperationException("Browser " + browser + " not found!");
                }


                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://Omada.net");
            }
        }

         internal static void QuitDriver()
            {
            if (driver != null)
                driver.Quit();
            }


    }
}
