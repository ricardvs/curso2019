using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Cl.Imagicair.Selenium
{
    public class FirstGoogle
    {
        [Test]
        public void Connect()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.cl");
                Assert.That(driver.Title, Is.EqualTo("Google"));

                driver.FindElement(By.XPath("/html//form[@id='tsf']//div[@class='a4bIc']/input[@role='combobox']"))
                .SendKeys("Debian latest version");

                driver.ExecuteScript("document.getElementById('footc').click()");

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".UUbT9 input[name='btnK']")));

                element.Click();
                Assert.That(driver.Url, Does.StartWith("https://www.google.cl/search"));
            }
        }

    }

}