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
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver= new ChromeDriver();
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            Actions ac = new Actions(driver);

            Console.WriteLine("Test Case started: ");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);




            DemoQAForms.forms(driver);


            DemoQAClass1.start(driver);
            DemoQAClass1.textbox(driver);
            DemoQAClass1.checkbox(driver);
            DemoQAClass1.radiobutton(driver); 
            DemoQAClass1.webtables(driver); 
            DemoQAClass1.buttons(driver);
            DemoQAClass1.linkTest(driver);
            DemoQAClass1.Blink(driver);
            DemoQAClass1.UPDP(driver); 
            DemoQAClass1.DynamicProperty(driver);
            DemoQAClass1.stop(driver);

            DemoQAClass2.start(driver);
            DemoQAClass2.browser(driver);
            DemoQAClass2.alert(driver);
            DemoQAClass2.frame(driver);
            DemoQAClass2.nestedframe(driver);
            DemoQAClass2.modal(driver);


            DemoQAWidgets.widgetstart(driver);
            DemoQAWidgets.Accordian(driver);
            DemoQAWidgets.DatePicker(driver);
            DemoQAWidgets.DateAndTimePicker(driver);
            DemoQAWidgets.MenuList(driver);
            DemoQAWidgets.ProgressBar(driver);
            DemoQAWidgets.SelectValue(driver);
            DemoQAWidgets.OldStyleSelectMenu(driver);
            DemoQAWidgets.StandardMultiSelect(driver);
            DemoQAWidgets.Slider(driver);
            DemoQAWidgets.Tab(driver);
            DemoQAWidgets.ToolsTips(driver);
            DemoQAWidgets.widgetstop(driver);


            DemoQAInteractions.startDrag(driver);
            DemoQAInteractions.SimpleDrag(driver);
            DemoQAInteractions.AxisRectrictedDrag(driver);
            DemoQAInteractions.ContainerRectrictedDrag(driver);
            DemoQAInteractions.CursorStyleDrag(driver);
            DemoQAInteractions.stopDrag(driver);


            DemoQAInteractions.SimpleDropp(driver);
            DemoQAInteractions.AcceptDropp(driver);
            DemoQAInteractions.PreventPropogationDropp(driver);
            DemoQAInteractions.RevertDropp(driver);


            DemoQAInteractions.LimitedReseize(driver);
            DemoQAInteractions.Reseize(driver);


            DemoQAInteractions.ListSelect(driver);
            DemoQAInteractions.GridSelect(driver);




            DemoQAInteractions.ListSort(driver);
            DemoQAInteractions.GridSort(driver);







            //DemoQABookStore.register(driver);
            DemoQABookStore.bookstart(driver);
            DemoQABookStore.login(driver);
            DemoQABookStore.GotoBookStore(driver);
            DemoQABookStore.SearchBook(driver);
            DemoQABookStore.DeleteBook(driver);
            DemoQABookStore.DeleteAllBook(driver); 
            DemoQABookStore.RowsIncrease(driver);
            DemoQABookStore.Search(driver);
            DemoQABookStore.AddToCollection(driver);
            DemoQABookStore.AddBook(driver);
            DemoQABookStore.bookstop(driver);



            //driver.Manage().Window.Minimize(); 
            Thread.Sleep(2000);
            Console.Write("Test Case Ended:");
            //driver.Close();
            driver.Dispose();
            driver.Quit();
        }
    }
}
