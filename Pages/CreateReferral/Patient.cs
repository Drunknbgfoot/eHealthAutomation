using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class Patient
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Patient(IWebDriver driver)
        {
            _driver = driver;
        }
        private static IWebElement ChoosePatient(IWebDriver driver)
        {
            IWebElement txt_ChoosePatient = driver.FindElement(By.CssSelector("input[placeholder='Enter patient name, DOB, or MRN to search']"));
            return txt_ChoosePatient;
        }
        private static IWebElement PatientMatch(IWebDriver driver, string patient)
        {
            //should grab the first match
            IWebElement btn_PatientName = driver.FindElement(By.CssSelector("button[ng-click='$ctrl.setSelectedItem(item)'"));
            return btn_PatientName;
        }
        private static IWebElement SelectedPatientCard(IWebDriver driver)
        {
            IWebElement btn_resetSelectedPatient = driver.FindElement(By.Id("resetSelectedItemBtn"));
            return btn_resetSelectedPatient;
        }
        private static IWebElement CancelChoosePatient(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.CssSelector("button[ng-click='cancel()']"));
            return btn_Cancel;
        }
        private static IWebElement Continuebutton(IWebDriver driver)
        {
            IWebElement btn_Continue = driver.FindElement(By.CssSelector("button[ng-click='createReferral()']"));
            return btn_Continue;
        }

        public static void SelectNextMatch(IWebDriver driver, string patient)
        {
            PatientMatch(driver, patient).Click();
        }
        
        public static void TypeChoosePatient(IWebDriver driver, string search)
        {
            ChoosePatient(driver).SendKeys(search);
        }
    }
}