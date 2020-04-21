using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class PracticeProviderMgt
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public PracticeProviderMgt(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement ListbyPractice(IWebDriver driver)
        {
            IWebElement rad_Practice = driver.FindElement(By.CssSelector("input[value='practices']"));
            return rad_Practice;
        }
        private static IWebElement UserSearch(IWebDriver driver)
        {
            IWebElement rad_UserSearch = driver.FindElement(By.CssSelector("input[value='contacts']"));
            return rad_UserSearch;
        }
        private static IWebElement PracticeDropdown(IWebDriver driver)
        {
            IWebElement cbo_Practice = driver.FindElement(By.Id("practice-menu"));
            return cbo_Practice;
        }
        private static IWebElement UserSearchTextbox(IWebDriver driver)
        {
            IWebElement txt_UserSearch = driver.FindElement(By.CssSelector("input[placeholder='Enter contact name or address to search'"));
            return txt_UserSearch;
        }
        private static IWebElement AddNewPractice(IWebDriver driver)
        {
            IWebElement btn_AddNewPrac = driver.FindElement(By.XPath("//*[text()='Add New Practice'"));
            return btn_AddNewPrac;
        }
        private static IWebElement AddPracticeUser(IWebDriver driver)
        {
            IWebElement btn_AddNewPracUser = driver.FindElement(By.XPath("//*[text()='Add Practice User'"));
            return btn_AddNewPracUser;
        }
        private static IWebElement EditPractice(IWebDriver driver)
        {
            IWebElement btn_EditPractice = driver.FindElement(By.XPath("//*[text()='Edit Practice'"));
            return btn_EditPractice;
        }
        private static IWebElement AddUserTextbox(IWebDriver driver)
        {
            //Choose Clinician
            IWebElement txt_AddUser = driver.FindElement(By.CssSelector("input[placeholder='Enter clinician name, NPI, and/or location to search'"));
            return txt_AddUser;
        }
        private static IWebElement CancelAddUser(IWebDriver driver)
        {
            IWebElement btn_CancelAddUser = driver.FindElement(By.XPath("//*[text()='Cancel'"));
            return btn_CancelAddUser;
        }
        private static IWebElement Closebutton(IWebDriver driver)
        {
            IWebElement btn_Close = driver.FindElement(By.ClassName("close"));
            return btn_Close;
        }
        private static IWebElement CreateNewPractice(IWebDriver driver)
        {
            IWebElement btn_CreateNewPrac = driver.FindElement(By.Id("create-new-practice"));
            return btn_CreateNewPrac;
        }
        private static IWebElement CreateNewPracticeTab(IWebDriver driver)
        {
            IWebElement tab_CreateNewPrac = driver.FindElement(By.Id("new-practice-or-provider-tabe"));
            return tab_CreateNewPrac;
        }
        private static IWebElement SearchNewPrac(IWebDriver driver)
        {
            IWebElement btn_SearchNewPrac = driver.FindElement(By.Id("search-button"));
            return btn_SearchNewPrac;
        }
        private static IWebElement CreatePractice(IWebDriver driver)
        {
            IWebElement btn_CreatePractice = driver.FindElement(By.XPath("//*[text()='Create Practice'"));
            return btn_CreatePractice;
        }
        
    }
}
