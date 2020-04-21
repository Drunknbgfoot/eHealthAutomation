using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class EditPatient
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public EditPatient(IWebDriver driver)
        {
            _driver = driver;
        }
        private static SelectElement AddnewPatientTitle(IWebDriver driver, string text)
        {
            IWebElement lst_Title = driver.FindElement(By.CssSelector("select[ng-model='patient.contactId.title'"));
            var selectele = new SelectElement(lst_Title);
            return selectele;
        }
        private static IWebElement FirstName(IWebDriver driver)
        {
            IWebElement txt_FName = driver.FindElement(By.XPath("//div[model='patient.contactId.firstName')]/input[1]"));
            return txt_FName;
        }
        private static IWebElement LastName(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.lastName')]/input[1]"));
            return obj;
        }
        private static IWebElement OtherNames(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[ng-model='patient.contactId.otherNames')]"));
            return obj;
        }
        private static IWebElement GenderMale(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[name='Male')]"));
            return obj;
        }
        private static IWebElement GenderFemale(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[name='Female')]"));
            return obj;
        }
        private static IWebElement GenderNotSpecified(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[name='Not Specified')]"));
            return obj;
        }
        private static IWebElement SSN(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.pii.ssn')]/input[1]"));
            return obj;
        }
        private static IWebElement Datefield(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.Id("dateField"));
            return obj;
        }
        private static IWebElement MRN(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.patientIdentifier')]/input[1]"));
            return obj;
        }
        private static IWebElement StreetAddress1(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.streetAddress1')]/input[1]"));
            return obj;
        }
        private static IWebElement StreetAddress2(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.streetAddress2')]/input[1]"));
            return obj;
        }
        private static IWebElement City(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.city')]/input[1]"));
            return obj;
        }
        private static SelectElement State(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("select[ng-model='patient.contactId.homeLocation.state')]"));
            var selectele = new SelectElement(obj);
            return selectele;
        }
        private static IWebElement ZIP(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.zipCode')]/input[1]"));
            return obj;
        }
        private static SelectElement Country(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("select[ng-model='patient.contactId.homeLocation.country')]"));
            var selectele = new SelectElement(obj);
            return selectele;
        }
        private static IWebElement PrimaryPhone(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.phonePrimary')]/input[1]"));
            return obj;
        }
        private static IWebElement SecondaryPhone(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//div[model='patient.contactId.homeLocation.phoneSecondary')]/input[1]"));
            return obj;
        }
        private static IWebElement Email(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//email-form-input[model='patient.contactId.homeLocation.email')]/input[1]"));
            return obj;
        }
        private static IWebElement AltContact(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[ng-model='hasAlternateContact')]"));
            return obj;
        }
        private static IWebElement Cancel(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("div[ng-click='cancel()')]"));
            return obj;
        }
        private static IWebElement UpdatePatient(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.Id("update-user-button"));
            return obj;
        }
    }
}