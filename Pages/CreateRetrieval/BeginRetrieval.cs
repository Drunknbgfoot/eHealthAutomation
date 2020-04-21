using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class BeginRetrieval
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public BeginRetrieval(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement RecordNeedbyDate(IWebDriver driver)
        {
            IWebElement txt_Date = driver.FindElement(By.Id("dateField"));
            return txt_Date;
        }
        private static SelectElement RecordsNeedforDropdown(IWebDriver driver)
        {
            IWebElement lst_RecordNeed = driver.FindElement(By.CssSelector("select[ng-model='retrievalReq.neededFor']"));
            var selectele = new SelectElement(lst_RecordNeed);
            return selectele;
        }
        private static SelectElement AuthPhysicianDropdown(IWebDriver driver)
        {
            IWebElement lst_AuthPhys = driver.FindElement(By.CssSelector("select[ng-model='retrievalReq.authorizingProvider']"));
            var selectele = new SelectElement(lst_AuthPhys);
            return selectele;
        }
        private static SelectElement PurposeReqDropdown(IWebDriver driver)
        {
            IWebElement lst_PurposeReq = driver.FindElement(By.CssSelector("select[ng-model='retrievalReq.purpose']"));
            var selectele = new SelectElement(lst_PurposeReq);
            return selectele;
        }
        private static IWebElement PatientAuthAvailCHK(IWebDriver driver)
        {
            IWebElement chk_Auth = driver.FindElement(By.CssSelector("input[ng-model='retrievalReq.authAvailable']"));
            return chk_Auth;
        }
        private static IWebElement NOPatientAuthAvailCHK(IWebDriver driver)
        {
            IWebElement chk_NOAuth = driver.FindElement(By.CssSelector("input[ng-model='retrievalReq.confirmAuthNotRequired']"));
            return chk_NOAuth;
        }
        private static IWebElement FileDropZone(IWebDriver driver)
        {
            IWebElement frm_Dropzone = driver.FindElement(By.Id("dropzone"));
            return frm_Dropzone;
        }
        

        public static void TypeRecordNeedByDate(IWebDriver driver, string date)
        {
            RecordNeedbyDate(driver).SendKeys(date);
        }

        public static void SelectRecordsNeedFor(IWebDriver driver, string reason)
        {
            RecordsNeedforDropdown(driver).SelectByText(reason);
        }

        public static void SelectAuthPhys(IWebDriver driver, string phys)
        {
            AuthPhysicianDropdown(driver).SelectByText(phys);
        }

        public static void SelectPurposeReq(IWebDriver driver, string purpose)
        {
            PurposeReqDropdown(driver).SelectByText(purpose);
        }

        public static void CheckPatientAuthAvail(IWebDriver driver)
        {
            if(!PatientAuthAvailCHK(driver).Selected)
            {
                PatientAuthAvailCHK(driver).Click();
            }
        }

        public static void UnCheckPatientAuthAvail(IWebDriver driver)
        {
            if(PatientAuthAvailCHK(driver).Selected)
            {
                PatientAuthAvailCHK(driver).Click();
            }
        }

        public static void CheckNOPatientAuthAvail(IWebDriver driver)
        {
            if(!NOPatientAuthAvailCHK(driver).Selected)
            {
                NOPatientAuthAvailCHK(driver).Click();
            }
        }
        
        public static void UnCheckNOPatientAuthAvail(IWebDriver driver)
        {
            if(NOPatientAuthAvailCHK(driver).Selected)
            {
                NOPatientAuthAvailCHK(driver).Click();
            }
        }
    }
}