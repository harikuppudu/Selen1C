using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selen1C.Tests
{
    public class SeleniumTest

    {

        [Test]

        public void firstseleniumtest()
        {
     

           IWebDriver driver = new ChromeDriver();
           driver.Navigate().GoToUrl("https://www.selenium.dev/");      
           Assert.That(driver.Title, Is.EqualTo("Selenium"));
           driver.Quit();


        }
    }
}
