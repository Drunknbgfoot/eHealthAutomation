using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class UserDeptMgt
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public UserDeptMgt(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement EnterContactNameAddy(IWebDriver driver)
        {
            IWebElement txt_EnterUserNameAddy = driver.FindElement(By.CssSelector("input[placeholder='Enter contact name or address to search'"));
            return txt_EnterUserNameAddy;
        }
        private static IWebElement AddUser(IWebDriver driver)
        {
            IWebElement btn_AddUser = driver.FindElement(By.XPath("//*[text()='Add User'"));
            return btn_AddUser;
        }
    }
}
