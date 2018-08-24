using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic
{
    class SeleniumSetMethods
    {
        public static void EnterText( string element, string text, PropertyType elementType)
        {
            if (elementType == PropertyType.Id )
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(text);
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(text);
        }

        public static void Click( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropDown( string element, string text, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(text);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(text);
        }
    }
}
