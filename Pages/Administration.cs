using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class Administration
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Administration(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement PracticeProviderManagement(IWebDriver driver)
        {
            IWebElement btn_Prac_Prov = driver.FindElement(By.CssSelector("a[href='/admin/physician-management']"));
            return btn_Prac_Prov;
        }
        private static IWebElement UserDepartmentManagement(IWebDriver driver)
        {
            IWebElement btn_User_Dep = driver.FindElement(By.CssSelector("a[href='/admin/user-management']"));
            return btn_User_Dep;
        }
        private static IWebElement SettingsConfig(IWebDriver driver)
        {
            IWebElement btn_Settings_Config = driver.FindElement(By.CssSelector("a[href='/admin/settings-and-configuration']"));
            return btn_Settings_Config;
        }
    }
}
