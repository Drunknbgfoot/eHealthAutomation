using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using CsQuery;

namespace netcore.template.Pages
{
    class ReportDemo
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public ReportDemo(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement ReturntoQueue(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Return to Queue']"));
            return obj;
        }
        private static IWebElement ExceptionObj(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Exception']"));
            return obj;
        }
        private static IWebElement Next(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//button[contains(text(), 'Next')]"));
            return obj;
        }
        private static IWebElement SearchByCaseNum(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[value='Search by Case Number']"));
            return obj;
        }
        private static IWebElement SearchByPatientName(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Search by Patient Name']"));
            return obj;
        }
        private static IWebElement SearchByDOB(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Search by DOB']"));
            return obj;
        }
        private static IWebElement CaseNumber(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[org-tabindex='1']"));
            return obj;
        }
        private static IWebElement IncludeCompletedCases1(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[org-tabindex='2']"));
            return obj;
        }
        private static IWebElement CaseNumberSearch(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[org-tabindex='3']"));
            return obj;
        }
        private static IWebElement PatientName(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[org-tabindex='4']"));
            return obj;
        }
        private static IWebElement IncludeCompletedCases2(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("input[org-tabindex='5']"));
            return obj;
        }
        private static IWebElement PatientNameSearch(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[org-tabindex='6']"));
            return obj;
        }
        private static IWebElement PatientDOB(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[org-tabindex='8']"));
            return obj;
        }
        private static IWebElement IncludeCompletedCases3(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[org-tabindex='9']"));
            return obj;
        }
        private static IWebElement DOBSearch(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[org-tabindex='10']"));
            return obj;
        }
        private static IWebElement PotentialCasesTopRow(IWebDriver driver, string text)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), '"+text+"')]")); 
            return obj;
        }
        private static IWebElement FacilityLocationDropdownArrow(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("span[class='arrow-down ']")));
            IWebElement obj = driver.FindElement(By.CssSelector("span[class='arrow-down ']"));
            return obj;
        }
        private static Boolean FacilityLocations(IWebDriver driver)
        {
            Boolean obj = driver.FindElements(By.CssSelector("div[class='dp-combobox-item ']")).Count() > 0;
            return obj;
        }
        private static IWebElement FacilityLocation(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("div[class='dp-combobox-item ']")); 
            return obj;
        }
        private static IWebElement CSSAttention(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'CSS Attention')]")); 
            return obj;
        }
        private static IWebElement AddCSSNote(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'Add CSS Note')]"));
            return obj;
        }
        private static IWebElement RTLAttention(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'RTL Attention')]")); 
            return obj;
        }
        private static IWebElement AddRTLNote(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'Add RTL Note')]"));
            return obj;
        }
        private static IWebElement IndexingAttention(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'Indexing Attention')]")); 
            return obj;
        }
        private static IWebElement AddIndexingNote(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'Add Indexing Note')]"));
            return obj;
        }
        private static IWebElement AddLocationNote(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.XPath("//*[contains(text(), 'Add Location Note')]"));
            return obj;
        }
        private static IWebElement AddNotePopup_Maximizebtn(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("rect[id='maximize']"));
            return obj;
        }
        private static IWebElement AddNotePopup_Closebtn(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("polgon[id='close']"));
            return obj;
        }
        private static IWebElement AddNotePopup_txtarea(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("textarea[class='textArea validation-Holder  ']"));
            return obj;
        }
        private static IWebElement AddNotePopup_Cancelbtn(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Cancel']"));
            return obj;
        }
        private static IWebElement AddNotePopup_Addbtn(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Add']"));
            return obj;
        }
        private static IWebElement ExceptionReasonDropArrow(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("span[class='arrow-down ']"));
            return obj;
        }
        private static IWebElement FirstExceptionReason(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("div[class='dp-combobox-item ']"));
            return obj;
        }
        private static IWebElement CancelExceptionReason(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Cancel']"));
            return obj;
        }
        private static IWebElement Completebutton(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Complete']"));
            return obj;
        }
        private static IWebElement SendExceptionReason(IWebDriver driver)
        {
            IWebElement obj = driver.FindElement(By.CssSelector("button[value='Send to Exception']"));
            return obj;
        }
        public static void ClickAddCSSNote(IWebDriver driver)
        {
            AddCSSNote(driver).Click();
        }
        public static void TypeNote(IWebDriver driver, string text)
        {
            AddNotePopup_txtarea(driver).SendKeys(text);
        }
        public static void ClickAddNote_popup(IWebDriver driver)
        {
            AddNotePopup_Addbtn(driver).Click();
        }
        public static void ClickReturntoQueue(IWebDriver driver)
        {
            ReturntoQueue(driver).Click();
        }
        public static void ClickException(IWebDriver driver)
        {
            ExceptionObj(driver).Click();
        }
        public static void ClickNext(IWebDriver driver)
        {
            Next(driver).Click();
        }
        public static void EnterPatientName(IWebDriver driver, string name)
        {
            PatientName(driver).SendKeys(name);
        }
        public static void ClickSearchPatient(IWebDriver driver)
        {
            PatientName(driver).SendKeys(Keys.Return);
        }
        public static void ClickFirstPatientCase(IWebDriver driver, string text)
        {
            PotentialCasesTopRow(driver, text).Click();
        }
        public static void ClickPatientCase(IWebDriver driver)
        {
            //await Task.Delay(2000);//allow page to render
            var actualPageSource = CQ.CreateDocument(driver.PageSource);
            var CaseNumbers = actualPageSource["th[id*='_CaseNumber_']"];
            var pairs = CaseNumbers.Select(node => new Tuple<string, string>(node.Id, node.Value));            
        }
        public static void ClickFacilityLocationDropDown(IWebDriver driver)
        {
            FacilityLocationDropdownArrow(driver).Click();
        }
        public static void VerifyFacilityLocationsExist(IWebDriver driver)
        {
            FacilityLocations(driver);
        }
        public static void ClickFirstFacilityLoc(IWebDriver driver)
        {
            FacilityLocation(driver).Click();
        }
        public static void ClickExceptionReasonDropArrow(IWebDriver driver)
        {
            try
            {
            ExceptionReasonDropArrow(driver).Click();
            }
            catch(StaleElementReferenceException st)
            {
              ExceptionReasonDropArrow(driver).Click();  
            }
        }
        public static void ClickFirstExceptionReason(IWebDriver driver)
        {
            FirstExceptionReason(driver).Click();
        }
        public static void ClickCancelExceptionReason(IWebDriver driver)
        {
            CancelExceptionReason(driver).Click();
        }
        public static void ClickSendExceptionReason(IWebDriver driver)
        {
            SendExceptionReason(driver).Click();
        }
        public static void ClickComplete(IWebDriver driver)
        {
            Completebutton(driver).Click();
        }
    }
}
