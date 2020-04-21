using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System;


namespace netcore.template.Pages
{
    class CommonOBJs
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public CommonOBJs(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement FindByText(IWebDriver driver, string text)
        {
            IWebElement obj_pageObject = driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            return obj_pageObject;
        }
        private static IWebElement Continuebtn(IWebDriver driver)
        {
            IWebElement btn_Continue = driver.FindElement(By.XPath("//button[contains(text(), 'Continue')]"));
            return btn_Continue;
        }
        private static IWebElement Previousbtn(IWebDriver driver)
        {
            IWebElement btn_Previous = driver.FindElement(By.XPath("//button[contains(text(), 'Previous')]"));
            return btn_Previous;
        }
        private static IWebElement Cancelbtn(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.XPath("//button[contains(text(), 'Cancel')]"));
            return btn_Cancel;
        }
        private static IWebElement EditPatient(IWebDriver driver)
        {
            IWebElement btn_EditPatient = driver.FindElement(By.CssSelector("a[ng-click, 'editPatient()']"));
            return btn_EditPatient;
        }

        public static void ClickText(IWebDriver driver, string text)
        {
            FindByText(driver, text).Click();
        }

        public static void VerifyText(IWebDriver driver, string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            if(!FindByText(driver,text).Displayed)
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),'" + text + "')]")));
                FindByText(driver,text).Displayed.Should().BeTrue();
            //string verify = FindByText(driver,text).Text;
            //text.Should().Be(verify);
            }
        }

        public static void ClickContinue(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(), 'Continue')]")));
            Continuebtn(driver).Click();
        }

        public static void ClickPrevious(IWebDriver driver)
        {
            Previousbtn(driver).Click();
        }

        public static void ClickCancel(IWebDriver driver)
        {
            try
            {
                Cancelbtn(driver).Click();
            }
            catch (OpenQA.Selenium.StaleElementReferenceException ex)
            {
                System.Console.Write(ex);
                Cancelbtn(driver).Click();
            }
        }

    }
}
