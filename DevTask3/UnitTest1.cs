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
            driver = new ChromeDriver();
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

        //Проверка раздела "GeoMeta"
        [Test]
        public void CheckGeoMeta()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            Assert.NotNull(driver.FindElement(By.XPath("//*[text()=\"GeoMeta\"]")));

        }

        //Проверка раздела "Государственная система обеспечения градостроительной деятельности"
        [Test]
        public void CheckGosSytem()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            var section = driver.FindElement(By.CssSelector("body > section.gos-system.bg_circle"));
            Assert.NotNull(section.FindElement(By.XPath("//*[text()=\"Государственная система обеспечения градостроительной деятельности\"]")));
            Assert.That("https://xn--c1aaceme9acfqh.xn--p1ai/", Is.EqualTo(section.FindElement(By.TagName("a")).GetAttribute("href")));
        }

        //Проверка раздела "Городская аналитика"
        [Test]
        public void CheckAnalitics()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            Assert.NotNull(driver.FindElement(By.XPath("//*[text()=\"Городская аналитика\"]")));

        }

        //Проверка "Других проектов"
        [Test]
        public void CheckOther()
        {
            driver.Url = "https://gemsdev.ru/geometa/";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(100, document.body.scrollHeight)");
            var section = driver.FindElement(By.CssSelector("body > section.other-products.bg_circle"));
            Assert.NotNull(section.FindElement(By.XPath("//*[text()[contains(.,\"наши продукты\")]]")));
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}