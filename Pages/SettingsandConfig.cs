using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class SettingsandConfig
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public SettingsandConfig(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
