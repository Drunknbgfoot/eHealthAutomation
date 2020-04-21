using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace netcore.template.Pages
{
    class Dashboard
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Dashboard(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement LnkDashboard(IWebDriver driver)
        {
            IWebElement lnk_Dashboard = driver.FindElement(By.CssSelector("a[href='/dashboard']"));
            return lnk_Dashboard;
        }
        private static IWebElement LnkAdministration(IWebDriver driver)
        {
            IWebElement lnk_Administration = driver.FindElement(By.CssSelector("a[href='/admin']"));
            return lnk_Administration;
        }
        private static IWebElement LnkHelpSupp(IWebDriver driver)
        {
            IWebElement lnk_HelpSupport = driver.FindElement(By.CssSelector("a[href='/support']"));
            return lnk_HelpSupport;
        }
        private static IWebElement PatientSearch(IWebDriver driver)
        {
            IWebElement txt_PatientSearch = driver.FindElement(By.CssSelector("input[placeholder='Patient Search']"));
            return txt_PatientSearch;
        }
        private static IWebElement Messages(IWebDriver driver)
        {
            IWebElement lnk_Messages = driver.FindElement(By.Id("messages"));
            return lnk_Messages;
        }
        private static IWebElement ToDo(IWebDriver driver)
        {
            IWebElement btn_ToDo = driver.FindElement(By.CssSelector("a[title='Retrieval Requests which require Attention']"));
            return btn_ToDo;
        }
        private static IWebElement CreatedToday(IWebDriver driver)
        {
            IWebElement btn_ToDo = driver.FindElement(By.CssSelector("a[title='Retrieval Requests which were created today']"));
            return btn_ToDo;
        }
        private static IWebElement AllPatients(IWebDriver driver)
        {
            IWebElement btn_ToDo = driver.FindElement(By.CssSelector("a[title='All Retrieval Requests created in the last 90 days']"));
            return btn_ToDo;
        }
        private static IWebElement RecycleBin(IWebDriver driver)
        {
            IWebElement btn_ToDo = driver.FindElement(By.CssSelector("a[title='Retrieval Requests which are Deleted']"));
            return btn_ToDo;
        }
        private static IWebElement NewRetrievalRequest(IWebDriver driver)
        {
            IWebElement btn_NewRetReq = driver.FindElement(By.CssSelector("button[title='Create Retrieval Request']"));
            return btn_NewRetReq;
        }
        private static IWebElement PatientName(IWebDriver driver, string text)
        {
            IWebElement lnk_PatientName = driver.FindElement(By.XPath("//a[contains(text(),'" + text + "'"));
            return lnk_PatientName;
        }
        private static IWebElement Recyclebutton(IWebDriver driver)
        {
            IWebElement btn_Recycle = driver.FindElement(By.XPath("//div[ng-click='moveRetrievalRequestToRecycleBin(item.retrievalRequest)']"));
            return btn_Recycle;
        }
        private static IWebElement AllPatientsTable(IWebDriver driver)
        {
            IWebElement tbl_AllPatients = driver.FindElement(By.XPath("//div[@id='all-patients']//table[1]"));
            return tbl_AllPatients;
        }
        private static List<IWebElement> RowList(IWebDriver driver)
        {
            List<IWebElement> rowList = AllPatientsTable(driver).FindElements(By.XPath("//div[@id='all-patients']//table[1]/tbody/tr")).ToList();
            return rowList;
        }
        private static IWebElement RecycleBinTable(IWebDriver driver)
        {
            IWebElement tbl_RecycleBin = driver.FindElement(By.XPath("//div[@id='recycle-bin']//table[1]"));
            return tbl_RecycleBin;
        }
        private static List<IWebElement> RecycleBinRows(IWebDriver driver)
        {
            List<IWebElement> rowList = RecycleBinTable(driver).FindElements(By.XPath("//div[@id='recycle-bin']//table[1]/tbody/tr")).ToList();
            return rowList;
        }
        private static IWebElement DeleteYes(IWebDriver driver, int row)
        {
            IWebElement btn_Yes = driver.FindElement(By.XPath("//div[@class='popover ng-scope left popover-left'][" + row + "]/div[@class='popover-content']//button[text()='Yes']"));
            return btn_Yes;
        }
        private static IWebElement btnDelete(IWebDriver driver, int row)
        {
            IWebElement btn_Delete = driver.FindElement(By.XPath("//div[@id='recycle-bin']//table[1]/tbody/tr[" + row + "]/td[7]/div[1]"));
            return btn_Delete;
        }
        private static IWebElement lblPatientName(IWebDriver driver, int row)
        {
            IWebElement btn_Name = driver.FindElement(By.XPath("//div[@id='recycle-bin']//table[1]/tbody/tr[" + row + "]/td"));
            return btn_Name;
        }
        private static IWebElement DeleteNO(IWebDriver driver)
        {
            IWebElement btn_NO = driver.FindElement(By.CssSelector("button[class='btn btn-block cancel-button ng-binding btn-default']"));
            return btn_NO;
        }
        public static void PageVerify(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("messages")));
            driver.Title.Should().Contain("eHealth Connect");
        }

        public static void ClickTODO(IWebDriver driver)
        {
            ToDo(driver).Click();
        }

        public static void ClickCreatedToday(IWebDriver driver)
        {
            CreatedToday(driver).Click();
        }

        public static void ClickAllPatients(IWebDriver driver)
        {
            AllPatients(driver).Click();
        }

        public static void ClickRecycleBin(IWebDriver driver)
        {
            RecycleBin(driver).Click();
        }

        public static void ClickNewRetReq(IWebDriver driver)
        {
            NewRetrievalRequest(driver).Click();
        }

        public static void ClickRecycleSelectPatient(IWebDriver driver, string text)
        {
            int row_num = 1;
            IWebElement btn_Recycle;
            IWebElement lnk_PatientName;
            foreach (IWebElement trElement in RowList(driver))
            {
                string patientName;
                lnk_PatientName = driver.FindElement(By.XPath("//tr[" + row_num + "]/td[2]/a"));
                patientName = lnk_PatientName.Text;
                if (patientName.Contains(text))
                {
                    try
                    {
                        btn_Recycle = driver.FindElement(By.XPath("//tr[" + row_num + "]/td[9]/div[1]"));
                        if (btn_Recycle.Displayed)
                        {
                            btn_Recycle.Click();
                            row_num = 1;
                        }
                    }
                    catch (StaleElementReferenceException st)
                    {
                        Console.WriteLine(st);
                        btn_Recycle = driver.FindElement(By.XPath("//tr[" + row_num + "]/td[9]/div[1]"));
                        if (btn_Recycle.Displayed)
                        {
                            btn_Recycle.Click();
                            row_num = 1;
                        }
                    }
                }
                else { row_num++; }
            }
        }

        public static void ClickDeletePatientRecBin(IWebDriver driver, string text)
        {
            int row_num = 1;
            string patientName;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            List<IWebElement> list = RecycleBinRows(driver);
            int length = list.Count + 1;

            while (row_num <= length)
            {
                try
                {
                    patientName = lblPatientName(driver, row_num).GetAttribute("innerHTML");
                }
                catch (StaleElementReferenceException st)
                {
                    Console.WriteLine(st);
                    patientName = lblPatientName(driver, row_num).GetAttribute("innerHTML");
                }
                patientName = patientName.Replace(" ", "");
                text = text.Replace(" ", "");
                if (patientName.Contains(text))
                {
                    try
                    {
                        Thread.Sleep(1000);
                        btnDelete(driver, row_num).Click();
                    }
                    catch (Exception ex)
                    {
                        if (ex is StaleElementReferenceException
                        || ex is ElementClickInterceptedException)
                        {
                            Console.WriteLine(ex);
                            Thread.Sleep(2500);
                            btnDelete(driver, row_num).Click();
                        }
                    }
                    js.ExecuteScript("arguments[0].click()", DeleteYes(driver, row_num));
                    length--;
                    Thread.Sleep(1000);
                }
                else { row_num++; }
            }
        }
    }
}
