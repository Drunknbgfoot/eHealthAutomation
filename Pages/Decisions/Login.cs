using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace netcore.template.Pages
{
    class Login_Decisions
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Login_Decisions(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement LoginUsername(IWebDriver driver)
        {
            IWebElement txt_LoginUsername = driver.FindElement(By.Id("txt_login_username"));
            return txt_LoginUsername;
        }
        private static IWebElement BtnLogin(IWebDriver driver)
        {
            IWebElement btn_Login = driver.FindElement(By.Id("btn_login_submit"));
            return btn_Login;
        }
        private static IWebElement Password(IWebDriver driver)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("password")));

            IWebElement txt_Password = driver.FindElement(By.Id("txt_login_password"));
            return txt_Password;
        }
        private static IWebElement RememberMe(IWebDriver driver)
        {
            IWebElement chk_RememberMe = driver.FindElement(By.Id("cb_login_remember"));
            return chk_RememberMe;
        }
        private static IWebElement ForgotPass(IWebDriver driver)
        {
            IWebElement lnk_ForgotPassword = driver.FindElement(By.Id("aForgotPassword"));
            return lnk_ForgotPassword;
        }
        private static IWebElement GetHelp(IWebDriver driver)
        {
            IWebElement lnk_GetHelp = driver.FindElement(By.Id("anc_getHelp"));
            return lnk_GetHelp;
        }
        private static IWebElement ContactUs(IWebDriver driver)
        {
            IWebElement lnk_ContactUs = driver.FindElement(By.Id("anc_contactUs"));
            return lnk_ContactUs;
        }

        public static void EnterEmail(IWebDriver driver, string username)
        {
            LoginUsername(driver).SendKeys(username);
            //LoginUsername(driver).Submit();
        }

        public static void EnterPassword(IWebDriver driver, string password)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("password")));
            Password(driver).SendKeys(password);
        }

        public static void ClickLogin(IWebDriver driver)
        {
            BtnLogin(driver).Click();
        }
    }
}
