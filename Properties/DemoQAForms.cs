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
    class DemoQAForms
    {
        public static void forms(IWebDriver driver)
        {

            string fname = "SHREYASHEE";
            string lname = "PANDIT";
            string phno = "9903872722";
            
            string email = "shreyashee@gmail.com";
            string CA = "Kolkata";
            

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions a = new Actions(driver);

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            

            driver.FindElement(By.Id("firstName")).SendKeys(fname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("lastName")).SendKeys(lname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='gender-radio-2']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("userNumber")).SendKeys(phno);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("react-datepicker__month-select")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[text()='July']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("react-datepicker__year-select")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[text()='2000']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@aria-label='Choose Wednesday, July 26th, 2000']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='subjects-auto-complete__value-container subjects-auto-complete__value-container--is-multi css-1hwfws3']")).Click();
            Thread.Sleep(2000);

            //driver.FindElement(By.XPath("//div[@class='subjects-auto-complete__value-container subjects-auto-complete__value-container--is-multi css-1hwfws3']")).SendKeys("Bengali");
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']")).Click();
            Thread.Sleep(2000);
            //driver.FindElement(By.Id("uploadPicture")).SendKeys(@"C:\This PC\Downloads\sampleFile (2).jpeg");
            //Thread.Sleep(2000);
            driver.FindElement(By.Id("currentAddress")).SendKeys(CA);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("userNumber")).SendKeys(Keys.Enter);


        }


    }
}
