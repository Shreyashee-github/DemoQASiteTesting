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
    class DemoQAInteractions
    {

        public static void startDrag(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions a = new Actions(driver);
            Console.WriteLine("\nInteraction Test Case started: ");
            Thread.Sleep(2000);

            Console.WriteLine("\nInteraction Drag Test Case started: ");
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://demoqa.com/interaction");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);
        }


        public static void SimpleDrag(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//span[text()='Dragabble']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(200, 150).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void AxisRectrictedDrag(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//a[@id='draggableExample-tab-axisRestriction']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@id='restrictedX']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(100, 0).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@id='restrictedY']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(0, 200).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void ContainerRectrictedDrag(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//a[@id='draggableExample-tab-containerRestriction']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(200, 100).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(driver.FindElement(By.XPath("//span[@class='ui-widget-header ui-draggable ui-draggable-handle']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(10, 30).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void CursorStyleDrag(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//a[@id='draggableExample-tab-cursorStyle']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@id='cursorCenter']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(100, 50).Release().Perform();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            ac.ClickAndHold(driver.FindElement(By.XPath("//div[@id='cursorTopLeft']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(60, 20).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(driver.FindElement(By.XPath("//span[text()='My cursor is at bottom']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(0, 100).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void stopDrag(IWebDriver driver)
        {
            
            Console.WriteLine("\nInteraction  Drag Test Case stoped: ");
            Thread.Sleep(2000);

           
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);

            
        }

        public static void SimpleDropp(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//span[text()='Droppable']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='draggable']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void AcceptDropp(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-accept']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='acceptable']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@class='accept-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='notAcceptable']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@class='accept-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void PreventPropogationDropp(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-preventPropogation']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='notGreedyDropBox']//p[text()='Outer droppable']"))).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='notGreedyInnerDropBox']"))).Release().Perform();
            Thread.Sleep(3000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='greedyDropBox']//p[text()='Outer droppable']"))).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='greedyDropBoxInner']"))).Release().Perform();
            Thread.Sleep(2000);
        }

        public static void RevertDropp(IWebDriver Driver)
        {

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-revertable']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='notRevertable']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@class='revertable-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(2000);
        }


        public static void LimitedReseize(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//span[text()='Resizable']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']")));
            Thread.Sleep(2000);

            ac.MoveByOffset(250, 200).Release().Perform();
            Thread.Sleep(2000);

        }

        public static void Reseize(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='resizable']//span[@class='react-resizable-handle react-resizable-handle-se']")));
            Thread.Sleep(2000);

            ac.MoveByOffset(400, 250).Release().Perform();
            Thread.Sleep(2000);
        }


        public static void ListSelect(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[text()='Selectable']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Porta ac consectetur ac']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Porta ac consectetur ac']")).Click();
            Thread.Sleep(2000);

        }

        public static void GridSelect(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='One']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Three']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Seven']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Nine']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Five']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='One']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Three']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Seven']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Nine']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//li[text()='Five']")).Click();
            Thread.Sleep(2000);

        }

        public static void ListSort(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//span[text()='Sortable']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            WebElement destination6 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Six']"));
            WebElement destination5 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Five']"));
            WebElement destination4 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Four']"));
            WebElement destination3 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Three']"));
            WebElement destination2 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Two']"));
            WebElement destination1 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='One']"));

            Actions action = new Actions(Driver);


            action.DragAndDrop(destination2, destination6).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination3, destination5).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination1, destination4).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination5, destination3).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination4, destination2).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination6, destination1).Build().Perform();
            Thread.Sleep(2000);

        }

        public static void GridSort(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);

            WebElement destination9 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Nine']"));
            WebElement destination8 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Eight']"));
            WebElement destination7 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Seven']"));
            WebElement destination6 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Six']"));
            WebElement destination5 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Five']"));
            WebElement destination4 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Four']"));
            WebElement destination3 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Three']"));
            WebElement destination2 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Two']"));
            WebElement destination1 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='One']"));

            Actions action = new Actions(Driver);


            action.DragAndDrop(destination8, destination6).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination3, destination5).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination1, destination4).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination5, destination8).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination7, destination2).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination6, destination3).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination4, destination7).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination2, destination9).Build().Perform();
            Thread.Sleep(2000);
            action.DragAndDrop(destination9, destination1).Build().Perform();
            Thread.Sleep(2000);

        }

    }
}
