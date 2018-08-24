using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic
{
    class Program
    {
        static void Main(string[] args)
        {}
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }

        [Test]
        public void ExecuteTest()
        {

            EAPageObject page = new EAPageObject();
            page.txtInitial.SendKeys("Vijay");
           

            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //SeleniumSetMethods.EnterText("Initial", "Vijay", PropertyType.Name);

            //Console.WriteLine($"The value of the Title is: {SeleniumGetMethods.GetTextFromDDL("TitleId",PropertyType.Id)}");

            Console.WriteLine($"The value of the Intial is: {SeleniumGetMethods.GetText("Initial",PropertyType.Name)}");

            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            page.btnSave.Click();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}
