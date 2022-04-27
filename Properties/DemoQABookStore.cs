using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQASiteTesting
{

    class DemoQABookStore
    {

        public static void bookstart(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions a = new Actions(driver);

            Console.WriteLine("Bookstore Test Case started: ");

            driver.Navigate().GoToUrl("https://demoqa.com/books");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);
        }
        public static void login(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("SHREYASHEE PANDIT");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Shreya@12");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='login']")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//a[@href='/profile']")).Click();
            //Thread.Sleep(2000);
        }


        public static void GotoBookStore(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//button[@id='gotoStore']")).Click();
            Thread.Sleep(2000);

        }

        public static void SearchBook(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[text()='Profile']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Git");
            Thread.Sleep(2000);

        }

        public static void DeleteBook(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//span[@id='delete-record-undefined']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);

            IAlert simpleAlert = Driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);
        }
        public static void DeleteAllBook(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//div[@class='text-right button di']//button[text()='Delete All Books']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);

            IAlert simpleAlert = Driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);
        }
        public static void RowsIncrease(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//select[@aria-label='rows per page']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//option[text()='10 rows']")).Click();
            Thread.Sleep(2000);
        }



        public static void Search(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Git");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Git Pocket Guide']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);
        }

        public static void AddToCollection(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//button[text()='Add To Your Collection']")).Click();
            Thread.Sleep(2000);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[text()='Back To Book Store']")).Click();
            Thread.Sleep(2000);
        }
        public static void AddBook(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Understanding");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Understanding ECMAScript 6']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            AddToCollection(driver);
            Thread.Sleep(2000);
        }

        public static void bookstop(IWebDriver driver)
        {
            
            Console.WriteLine("Bookstore Test Case stoped: ");

            
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);

            
        }


    }
}
