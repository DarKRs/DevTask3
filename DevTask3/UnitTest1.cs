using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System;

namespace DevTask3
{
    public class Tests
    {
        IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver("C:\\");
            driver.Manage().Window.Maximize();
        }


        //Переход на страницу продкутов
        [Test]
        public void GoToProductPage()
        {
            driver.Url = "https://gemsdev.ru/";
            try
            {
                driver.FindElement(By.XPath("/html/body/header/div/div/div[3]/nav/ul/li[2]/a")).Click();
                
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }
            //Assert.Pass();
        }

        [Test]
        public void CheckGeoMeta()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            Assert.NotNull(driver.FindElement(By.XPath("//*[text()=\"GeoMeta\"]")));

        }
       
        [Test]
        public void CheckGosSytem()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            var a = driver.FindElement(By.XPath("//section[text()=\"Государственная система обеспечения градостроительной деятельности\"]"));
            Assert.NotNull(driver.FindElement(By.XPath("//*[text()=\"Государственная система обеспечения градостроительной деятельности\"]")));

        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}