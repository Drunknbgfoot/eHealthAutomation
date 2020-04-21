using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class ConfirmandFinish
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public ConfirmandFinish(IWebDriver driver)
        {
            _driver = driver;
        }
        private static IWebElement EditPatient(IWebDriver driver)
        {
            IWebElement btn_EditPatient = driver.FindElement(By.CssSelector("a[ng-click = 'editPatient()']"));
            return btn_EditPatient;
        }
        private static IWebElement IncludePreviewCHK(IWebDriver driver)
        {
            IWebElement chk_IncludePreview = driver.FindElement(By.CssSelector("input[ng-model = 'printableSummaryRequested']"));
            return chk_IncludePreview;
        }
        private static IWebElement SubmitRequest(IWebDriver driver)
        {
            IWebElement btn_SubmitRequest = driver.FindElement(By.CssSelector("button[ng-click = 'submitRetrievalRequest()']"));
            return btn_SubmitRequest;
        }
        private static IWebElement Previousbtn(IWebDriver driver)
        {
            IWebElement btn_Previous = driver.FindElement(By.XPath("//button[contains(text() = 'Previous')]"));
            return btn_Previous;
        }
        private static IWebElement Cancelbtn(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.XPath("//button[contains(text() = 'Cancel')]"));
            return btn_Cancel;
        }
    }
}