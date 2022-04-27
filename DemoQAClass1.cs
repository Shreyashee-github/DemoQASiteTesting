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

    class DemoQAClass1
    {
        //Elements

        
        public static void start(IWebDriver driver)
        {
            Console.WriteLine("Elements Test Case started: ");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            Thread.Sleep(1000);

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        public static void textbox(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;


            driver.FindElement(By.XPath("//li[@id='item-0']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("SHREYASHEE PANDIT");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@id='userEmail']")).SendKeys("panditkonnagar@gmail.com");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//textarea[@id='currentAddress']")).SendKeys("Kolkata");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//textarea[@id='permanentAddress']")).SendKeys("London");
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,200)");
            //driver.FindElement(By.XPath("//button[@id='submit']")).Click();
        }

        public static void checkbox(IWebDriver driver)
        {
            driver.FindElement(By.Id("item-1")).Click();
            Thread.Sleep(2000);
            
            driver.FindElement(By.ClassName("rct-option-expand-all")).Click();
            Thread.Sleep(2000);
        }


        public static void radiobutton(IWebDriver driver)
        {
            driver.FindElement(By.Id("item-2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='yesRadio']")).Click();
            //driver.FindElement(By.XPath("//label[@for='impressiveRadio']")).Click();
            //driver.FindElement(By.XPath("//label[@for='noRadio']")).Click();
            //driver.FindElement(By.Id("yesRadio")).Click();
            //driver.FindElement(By.Id("impressiveRadio")).Click();
            //driver.FindElement(By.Id("noRadio")).Click();
            Thread.Sleep(2000);
        }

        public static void webtables(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;



            driver.FindElement(By.Id("item-3")).Click();
            Thread.Sleep(2000);
            string fname = "SHREYASHEE";
            string lname = "PANDIT";
            string age = "25";
            string email = "panditkonnagar@gmail.com";
            string salary = "900000000000000";
            string dept = "Engineer";
            string search = "SHREYASHEE";
            //driver.FindElement(By.XPath("//*[Text()='Web Tables']")).Click();
            driver.FindElement(By.XPath("//*[text()='Add']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("firstName")).SendKeys(fname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("lastName")).SendKeys(lname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("age")).SendKeys(age);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("salary")).SendKeys(salary);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("department")).SendKeys(dept);
            Thread.Sleep(2000);
            //Driver.FindElement(By.Id("department")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("searchBox")).SendKeys(search);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            driver.FindElement(By.Id("delete-record-4")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("searchBox")).Clear();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");



        }

        public static void buttons(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.Id("item-4")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.MoveToElement(driver.FindElement(By.Id("doubleClickBtn"))).DoubleClick().Build().Perform();
            Thread.Sleep(2000);
            ac.MoveToElement(driver.FindElement(By.Id("rightClickBtn"))).ContextClick().Build().Perform();
            Thread.Sleep(2000);
            //ac.MoveToElement(driver.FindElement(By.Id("gaWl0"))).ContextClick().Build().Perform();
            driver.FindElement(By.XPath("//*[text()='Click Me']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
        }


        public static void linkTest(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.Id("item-5")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);
            string a;
            string b;
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            driver.SwitchTo().Window(b);
            driver.Manage().Window.Minimize();
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);
            driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(2000);
            b = driver.WindowHandles[1];
            driver.SwitchTo().Window(b);
            driver.Manage().Window.Minimize();
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("unauthorized")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

        }



        public static void Blink(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Broken Links Images-item6
            driver.FindElement(By.Id("item-6")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);


        }


        public static void UPDP(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Upload Download-item7
            driver.FindElement(By.Id("item-7")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);
        }

        public static void DynamicProperty(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Dynamic Properties-item8
            driver.FindElement(By.Id("item-8")).Click();
            Thread.Sleep(7000);


        }
           







        public static void stop(IWebDriver driver)
        {
            driver.Manage().Window.Minimize();
            Thread.Sleep(1000);
            Console.Write("Elements Test Case Ended:");
            driver.Close();
            
        }



    }
}
