using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class RetrievalRequestInfo
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public RetrievalRequestInfo(IWebDriver driver)
        {
            _driver = driver;
        }
        private static IWebElement FindByText(IWebDriver driver, string text)
        {
            IWebElement obj_pageObject = driver.FindElement(By.XPath("//*[contains(text(),'"+text+"')]"));
            return obj_pageObject;
        }
        private static SelectElement DepartmentRequestedDropdown(IWebDriver driver)
        {
            IWebElement lst_DeptReq = driver.FindElement(By.CssSelector("select[ng-model='referral.department']"));
            var selectele = new SelectElement(lst_DeptReq);
            return selectele;
        }
        private static SelectElement ReferralReasonDropdown(IWebDriver driver)
        {
            IWebElement lst_RefReason = driver.FindElement(By.CssSelector("select[ng-model='referral.reasonForReferral']"));
            var selectele = new SelectElement(lst_RefReason);
            return selectele;
        }
        private static SelectElement InsuranceProviderDropdown(IWebDriver driver)
        {
            IWebElement lst_InsuranceProv = driver.FindElement(By.CssSelector("select[ng-model='referral.insuranceProvider']"));
            var selectele = new SelectElement(lst_InsuranceProv);
            return selectele;
        }
        private static IWebElement CancelRRI(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.CssSelector("button[ng-click='cancelWithoutSave()']"));
            return btn_Cancel;
        }
        private static IWebElement EditPatient(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.CssSelector("button[ng-click='editPatient()']"));
            return btn_Cancel;
        }
        private static IWebElement ContinueRRI(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.XPath("//button[contains(text(),'Continue')]"));
            return btn_Cancel;
        }

        public static void SelectDepartment(IWebDriver driver, string dept)
        {
            DepartmentRequestedDropdown(driver).SelectByText(dept);
        }

        public static void SelectReferralReason(IWebDriver driver, string referral)
        {
            ReferralReasonDropdown(driver).SelectByText(referral);
        }

        public static void SelectInsuranceProvider(IWebDriver driver, string insurance)
        {
            InsuranceProviderDropdown(driver).SelectByText(insurance);
        }
    }
}