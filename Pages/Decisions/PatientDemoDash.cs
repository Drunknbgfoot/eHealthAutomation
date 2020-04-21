using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using FluentAssertions;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


namespace netcore.template.Pages
{
    class PatientDemoDash
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public PatientDemoDash(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement PatientDemoDashboard(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-folder-page-name='Patient Demo Dashboard']")));
            IWebElement obj = driver.FindElement(By.CssSelector("a[data-folder-page-name='Patient Demo Dashboard']"));
            return obj;
        }
        private static IWebElement ExceptionDashboard(IWebDriver driver)
        { 
            Thread.Sleep(10000);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("a[data-folder-page-name='Exception Dashboard']")));
            IWebElement obj = driver.FindElement(By.CssSelector("a[data-folder-page-name='Exception Dashboard']"));
            return obj;
        }
        private static IWebElement ReviewDashboard(IWebDriver driver)
        {
            Thread.Sleep(10000);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("a[data-folder-page-name='Review Dashboard']")));
            IWebElement obj = driver.FindElement(By.CssSelector("a[data-folder-page-name='Review Dashboard']"));
            return obj;
        }
        private static IWebElement ReportViewerTable(IWebDriver driver)
        {
            IWebElement tbl_ReportViewer = driver.FindElement(By.CssSelector("table[id^=reportGrid]"));
            return tbl_ReportViewer;
        }
        private static List<IWebElement> ReportViewerRow(IWebDriver driver)
        {
            List<IWebElement> tableRows = ReportViewerTable(driver).FindElements(By.TagName("tr")).ToList();
            return tableRows;
        }
        private static IWebElement ReportViewerCell(IWebDriver driver, string CellText)
        {
            IWebElement row = ReportViewerRow(driver).Where(item => item.Text.Contains(CellText)).FirstOrDefault();

            return row;
        }
        public static string GetFaxNumatSelecteddemo(IWebDriver driver, string CellText)
        {
            Thread.Sleep(10000);
            try
            {
            IWebElement row = ReportViewerRow(driver).Where(item => item.Text.Contains(CellText)).FirstOrDefault();
            string fax = row.Text;
            string[] sp = new string[] {" "};
            string[] whole;
            whole = fax.Split(sp,StringSplitOptions.None);
            string faxNumber = whole[2];
             return faxNumber;
            }
            catch(StaleElementReferenceException st)
            {            
                IWebElement row = ReportViewerRow(driver).Where(item => item.Text.Contains(CellText)).FirstOrDefault();
                string fax = row.Text;
                string[] sp = new string[] {" "};
            string[] whole;
            whole = fax.Split(sp,StringSplitOptions.None);
            string faxNumber = whole[2];
             return faxNumber;
            }
            

        }
        public static void GetFaxNum(IWebDriver driver, string fax)
        {
            try
            {
                List<IWebElement> faxnum = ReportViewerRow(driver).Where(item => item.Text.Contains(fax)).ToList();
            }
            catch(StaleElementReferenceException st)
            {
                List<IWebElement> faxnum = ReportViewerRow(driver).Where(item => item.Text.Contains(fax)).ToList();
            }
        }
        private static IWebElement PerformDemo(IWebDriver driver)
        {
            IWebElement btn_PerformDemo = driver.FindElement(By.CssSelector("span[data-action-name='Perform%20Demo']"));
            return btn_PerformDemo;
        }
        private static IWebElement ReviewException(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("span[data-action-name='Review%20Exception']")));
            IWebElement btn = driver.FindElement(By.CssSelector("span[data-action-name='Review%20Exception']"));
            return btn;
        }
        private static IWebElement Search(IWebDriver driver)
        {
            IWebElement txt_Search = driver.FindElement(By.CssSelector("input[placeholder='SEARCH...']"));
            return txt_Search;
        }
        public static void PageVerify(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("PageHeader")));
            driver.Title.Should().Contain("Decisions");
        }

        public static void ClickFirstRegionByText(IWebDriver driver, string Text)
        {
            Thread.Sleep(10000);
            Actions action = new Actions(driver);
            action.ContextClick(ReportViewerCell(driver, Text));
            action.Build().Perform();
            //ReportViewerTable(driver).Click();
        }

        public static void ClickPerformDemo(IWebDriver driver)
        {
            PerformDemo(driver).Click();
        }
        public static void ClickReviewException(IWebDriver driver)
        {
            ReviewException(driver).Click();
        }
        public static void ClickPatientDemoDashTab(IWebDriver driver)
        {
            Thread.Sleep(5000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            PatientDemoDashboard(driver).Click();
        }
        public static void ClickExceptionDemoDashTab(IWebDriver driver)
        {
            Thread.Sleep(5000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            ExceptionDashboard(driver).Click();
        }
        public static void ClickReviewDemoDashTab(IWebDriver driver)
        {
            Thread.Sleep(5000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            ReviewDashboard(driver).Click();
        }
    }
}