using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class HelpSupport
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public HelpSupport(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement Email(IWebDriver driver)
        {
            IWebElement lnk_Email = driver.FindElement(By.CssSelector("a[href='mailto:support@ehealthtechnologies.com']"));
            return lnk_Email;
        }
    }
}
