using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;


namespace SeleniumNUnitJenkins
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;


        [SetUp]
        public void SetUp()
        {
            _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), DesiredCapabilities.Firefox());
        }

        [Test]
        public void Test1()
        {
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            _driver.Navigate().GoToUrl("http://www.google.com/");
        }
    }
}
