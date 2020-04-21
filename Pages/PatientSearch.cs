using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class PatientSearch
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public PatientSearch(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
