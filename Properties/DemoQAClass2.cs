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
    class DemoQAClass2
    {

        public static void start(IWebDriver driver)
        {
            Console.WriteLine("\nAlerts, Frame & Windows Test Case started: ");
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://demoqa.com/alertsWindows");
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }


        public static void browser(IWebDriver driver)
        {
            
            driver.FindElement(By.XPath("//*[text()='Browser Windows']")).Click();
           
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[@id='tabButton']")).Click(); 
            Thread.Sleep(1000);
            string a;
            string b;
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            driver.SwitchTo().Window(b);
            driver.Manage().Window.Minimize();
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);

            driver.FindElement(By.XPath("//button[@id='windowButton']")).Click();
            Thread.Sleep(1000); 
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            driver.SwitchTo().Window(b);
            driver.Close();

            driver.SwitchTo().Window(a);
            driver.FindElement(By.XPath("//button[@id='messageWindowButton']")).Click();
            Thread.Sleep(1000); 
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            driver.SwitchTo().Window(b);
            driver.Close();

            driver.SwitchTo().Window(a);



        }


        public static void alert(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[text()='Alerts']")).Click(); 
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Thread.Sleep(1000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            

            //driver.SwitchTo().Window(b);
            //driver.Close();
            driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(7000);
            var alert_win1 = driver.SwitchTo().Alert();
            alert_win1.Accept();
            driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(1000);
            var alert_win2 = driver.SwitchTo().Alert();
            alert_win2.Accept();
            //alert_win2.Dismiss();
            
            driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            
            Thread.Sleep(1000);
            
            var alert_win3 = driver.SwitchTo().Alert();
            alert_win3.SendKeys("I am SHREYASHEE PANDIT");
            Thread.Sleep(2000);
            alert_win3.Accept();
            Thread.Sleep(2000);
            
        }

        public static void frame(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[text()='Frames']")).Click();
            Thread.Sleep(1000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Frames']")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='frame2']")));
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(200,0)");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,-300)");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(-200,0)");
            Thread.Sleep(2000);

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
        }


        public static void nestedframe(IWebDriver driver)
        {
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Nested Frames']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='frame1']")));
            Thread.Sleep(2000);

            //Switch to Child Frames
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@srcdoc='<p>Child Iframe</p>']")));
            Thread.Sleep(2000);

            //Switch to Parent Frames
            driver.SwitchTo().ParentFrame();
            Thread.Sleep(2000);

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            Console.WriteLine("Nested Window performed");
        }

        public static void modal(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Modal Dialogs']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[@id='showSmallModal']")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().ActiveElement();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@id='closeSmallModal']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[@id='showLargeModal']")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().ActiveElement();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            Thread.Sleep(1000);
            



        }
    }
    
}
