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
    class DemoQAWidgets
    {

        public static void widgetstart(IWebDriver driver)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions a = new Actions(driver);
            Console.WriteLine("\nWidgets Test Case started: ");
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://demoqa.com/widgets");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);
        }

        public static void Accordian(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//span[text()='Accordian']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[@id='section3Heading']")).Click();
            Thread.Sleep(2000);
        }

       

        public static void DatePicker(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//span[text()='Date Picker']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//option[text()='July']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//option[text()='2002']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[text()='Date And Time']")).Click();
            Thread.Sleep(2000);
            
        }

        public static void DateAndTimePicker(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Next Month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Next Month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Next Month']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='react-datepicker__year-read-view']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='react-datepicker__navigation react-datepicker__navigation--years react-datepicker__navigation--years-previous']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[text()='2017']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[text()='22']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[text()='15:15']")).Click();
            Thread.Sleep(2000);
        }

        public static void MenuList(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Menu']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Main Item 1']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.MoveToElement(driver.FindElement(By.XPath("//a[text()='Main Item 2']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(driver.FindElement(By.XPath("//a[text()='SUB SUB LIST »']"))).Build().Perform();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Sub Sub Item 2']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Main Item 3']")).Click();
            Thread.Sleep(2000);

        }

        public static void ProgressBar(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Progress Bar']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(2000);

        }


        public static void SelectValue(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Select Menu']")).Click();
            Thread.Sleep(2000);

            
        }
        public static void OldStyleSelectMenu(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");

            driver.FindElement(By.XPath("//select[@id='oldSelectMenu']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//option[text()='Purple']")).Click();
            Thread.Sleep(2000);
        }
        public static void StandardMultiSelect(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//option[text()='Volvo']")).Click();
            Thread.Sleep(2000);
            WebElement l = (WebElement)driver.FindElement(By.XPath("//option[text()='Saab']"));

            Actions ac = new Actions(driver);

            ac.MoveToElement(driver.FindElement(By.XPath("//option[text()='Saab']"))).KeyDown(Keys.Control).Click().Build().Perform();
            Thread.Sleep(2000);
        }


        public static void Slider(IWebDriver Driver)
        {

            Driver.FindElement(By.XPath("//span[text()='Slider']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']")));
            Thread.Sleep(2000);

            ac.MoveByOffset(45, 0).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(-55, 0).Build().Perform();
            Thread.Sleep(2000);
        }

        public static void Tab(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Tabs']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[@id='demo-tab-use']")).Click();
            Thread.Sleep(2000);
        }

        public static void ToolsTips(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Tool Tips']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[text()='Hover me to see']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//input[@id='toolTipTextField']")).SendKeys("popular");
            Thread.Sleep(2000);
        }

        public static void widgetstop(IWebDriver driver)
        {
            
            Console.WriteLine("\nWidgets Test Case stoped: ");
            Thread.Sleep(2000);

            
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);

            
        }
    }

}
