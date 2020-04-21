using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class Confirm
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Confirm(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}