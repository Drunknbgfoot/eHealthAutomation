using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using CsQuery;

namespace netcore.template.Pages
{
    class ReportDemopg2
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public ReportDemopg2(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement SpecialTypeDropdownArrow(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("span[class='arrow-down ']")));
            IWebElement obj = driver.FindElement(By.CssSelector("span[class='arrow-down ']"));
            return obj;
        }
        private static Boolean SpecialTypeExist(IWebDriver driver)
        {
            Boolean obj = driver.FindElements(By.CssSelector("div[class='dp-combobox-item ']")).Count() > 0;
            return obj;
        }
        private static IWebElement SpecialType(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("div[class='dp-combobox-item ']")); 
            return obj;
        }
        private static IWebElement CSSAttention(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//label[contains(text(), 'CSS Attention')]"));
            return obj;
        }
        private static IWebElement RTLAttention(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//label[contains(text(), 'RTL Attention')]"));
            return obj;
        }
        private static IWebElement AddPhoneFax(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//button[contains(text(), '        Add Phone/Fax Number    ')]"));
            return obj;
        }
        private static IWebElement Approve(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Approve']"));
            return obj;
        }

        public static void ClickSpecialTypeDropDown(IWebDriver driver)
        {
            SpecialTypeDropdownArrow(driver).Click();
        }
        public static void VerifySpecialTypeExist(IWebDriver driver)
        {
            SpecialTypeExist(driver);
        }
        public static void ClickFirstSpecialTypeLoc(IWebDriver driver)
        {
            SpecialType(driver).Click();
        }
        public static void ClickCSSAttention(IWebDriver driver)
        {
            CSSAttention(driver).Click();
        }
        public static void ClickApprove(IWebDriver driver)
        {
            Approve(driver).Click();
        }
    }
}