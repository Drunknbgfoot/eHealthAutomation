using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace netcore.template.Pages
{
    class UploadFiles
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public UploadFiles(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement FileDropZone(IWebDriver driver)
        {
            IWebElement frm_Dropzone = driver.FindElement(By.Id("dropzone"));
            return frm_Dropzone;
        }

        public static void VerifyFileZone(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("dropzone")));
            //FileDropZone(driver).Click();
        }
    }
}