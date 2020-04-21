using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace netcore.template.Pages
{
    class SelectProvider
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public SelectProvider(IWebDriver driver)
        {
            _driver = driver;
        }
        
        private static IWebElement NoPractice(IWebDriver driver)
        {
            IWebElement chk_NOPractice = driver.FindElement(By.XPath("//*[heading='Practice']//input[ng-model='$ctrl.hideSearch.value']"));
            return chk_NOPractice;
        }
        private static IWebElement NoProvider(IWebDriver driver)
        {
            IWebElement objtest = driver.FindElement(By.XPath("//*[@heading='Provider']"));
            IWebElement chk_NOProvider = driver.FindElement(By.XPath("//*[@heading='Provider']/div/div/input[@ng-model='$ctrl.hideSearch.value']"));
            return chk_NOProvider;
        }
        private static IWebElement ChoosePractice(IWebDriver driver)
        {
            IWebElement txt_ChoosePractice = driver.FindElement(By.CssSelector("input[placeholder='Practice name, street address, zip code, and/or NPI (required)']"));
            return txt_ChoosePractice;
        }
        private static IWebElement ChooseProvider(IWebDriver driver)
        {
            IWebElement txt_ChooseProvider = driver.FindElement(By.CssSelector("input[placeholder='Provider name, street address, zip code, and/or NPI (required)']"));
            return txt_ChooseProvider;
        }
        private static IWebElement FindSpantext(IWebDriver driver, string text)
        {
            IWebElement txt_Obj = driver.FindElement(By.CssSelector("span:contains('"+text+"')"));
            return txt_Obj;
        }
        private static IWebElement SelectFirstPractice(IWebDriver driver)
        {
            IWebElement lnk_obj = driver.FindElement(By.CssSelector("span[ng-bind-html='item.nameMarked']"));
            return lnk_obj;
        }
        private static IWebElement SelectPractice(IWebDriver driver, string practice)
        {
            IWebElement lnk_obj = driver.FindElement(By.CssSelector("span[ng-bind-html='item.name'][contains(text(),'"+practice+"')]"));
            return lnk_obj;
        }
        private static IWebElement AddPracticeProvider(IWebDriver driver)
        {
            IWebElement btn_AddPractice = driver.FindElement(By.CssSelector("span[ng-click='$ctrl.setSelectedItemFromAdded()']"));
            return btn_AddPractice;
        }
        private static IWebElement AddNewProviderRequest(IWebDriver driver)
        {
            IWebElement btn_AddProvider = driver.FindElement(By.CssSelector("div[ng-click='addProviderRequest()']"));
            return btn_AddProvider;
        }
        private static IWebElement AddClonedRequest(IWebDriver driver)
        {
            IWebElement btn_AddCloned = driver.FindElement(By.CssSelector("div[ng-click='copyActiveProviderRequest()']"));
            return btn_AddCloned;
        }
        private static IWebElement Continuebtn(IWebDriver driver)
        {
            IWebElement btn_Continue = driver.FindElement(By.XPath("//button[contains(text(), 'Continue')]"));
            return btn_Continue;
        }
        private static IWebElement Previousbtn(IWebDriver driver)
        {
            IWebElement btn_Previous = driver.FindElement(By.XPath("//button[contains(text(), 'Previous')]"));
            return btn_Previous;
        }
        private static IWebElement Cancelbtn(IWebDriver driver)
        {
            IWebElement btn_Cancel = driver.FindElement(By.XPath("//button[contains(text(), 'Cancel')]"));
            return btn_Cancel;
        }
        private static IWebElement AddRecordbutton(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Records']//div[@name='addButton']"));
            return btn_Add;
        }
        private static IWebElement AddRecorddropdown(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Records']//div[@data-toggle='dropdown']"));
            return btn_Add;
        }
        private static IWebElement AddImagingbutton(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Imaging']//div[@name='addButton']"));
            return btn_Add;
        }
        private static IWebElement AddImagingdropdown(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Imaging']//div[@data-toggle='dropdown']"));
            return btn_Add;
        }
        private static IWebElement AddPathbutton(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Pathology']//div[@name='addButton']"));
            return btn_Add;
        }
        private static IWebElement AddPathdropdown(IWebDriver driver)
        {
            IWebElement btn_Add = driver.FindElement(By.XPath("//requested-item-list[@heading='Pathology']//div[@data-toggle='dropdown']"));
            return btn_Add;
        }
        private static IWebElement Close(IWebDriver driver)
        {
            IWebElement btn_Close = driver.FindElement(By.Id("closeButton"));
            return btn_Close;
        }
        private static IWebElement Replace(IWebDriver driver)
        {
            IWebElement btn_Replace = driver.FindElement(By.CssSelector("div[ng-click='replace()']"));
            return btn_Replace;
        }
        private static IWebElement Merge(IWebDriver driver)
        {
            IWebElement btn_Merge = driver.FindElement(By.CssSelector("div[ng-click='merge()']"));
            return btn_Merge;
        }
        private static IWebElement Description(IWebDriver driver)
        {
            IWebElement txt_Description = driver.FindElement(By.CssSelector("input[column-field-name='description']"));
            return txt_Description;
        }
        private static IWebElement BodyPart(IWebDriver driver)
        {
            IWebElement txt_BodyPart = driver.FindElement(By.CssSelector("input[column-field-name='bodyPart']"));
            return txt_BodyPart;
        }
        private static IWebElement AccessionNum(IWebDriver driver)
        {
            IWebElement txt_AccessionNum = driver.FindElement(By.CssSelector("input[column-field-name='accessionNumber']"));
            return txt_AccessionNum;
        }
        private static IWebElement DateRange(IWebDriver driver)
        {
            IWebElement txt_DateRange = driver.FindElement(By.CssSelector("input[column-field-name='dateRange']"));
            return txt_DateRange;
        }
        private static IWebElement ConfirmRecord(IWebDriver driver)
        {
            IWebElement btn_Checkmark = driver.FindElement(By.CssSelector("div[ng-click='$ctrl.commitEdit(item)']"));
            return btn_Checkmark;
        }
        private static IWebElement CancelRecord(IWebDriver driver)
        {
            IWebElement btn_X = driver.FindElement(By.CssSelector("div[ng-click='$ctrl.deleteItem(item)']"));
            return btn_X;
        }
        private static IWebElement EditRecord(IWebDriver driver)
        {
            IWebElement btn_Edit = driver.FindElement(By.CssSelector("div[ng-click='$ctrl.editingItem = item']"));
            return btn_Edit;
        }
        private static IWebElement Explanation(IWebDriver driver)
        {
            IWebElement txt_Explanation = driver.FindElement(By.CssSelector("textarea[ng-model='$ctrl.providerRequest.explanation']"));
            return txt_Explanation;
        }
        private static IWebElement Delete(IWebDriver driver)
        {
            IWebElement btn_Delete = driver.FindElement(By.CssSelector("div[title='Confirm Delete']"));
            return btn_Delete;
        }
        private static IWebElement ConfirmDeleteYes(IWebDriver driver)
        {
            IWebElement btn_YESDelete = driver.FindElement(By.XPath("//button[contains(text() = 'Yes')]"));
            return btn_YESDelete;
        }
        private static IWebElement CancelDeleteNO(IWebDriver driver)
        {
            IWebElement btn_NODelete = driver.FindElement(By.XPath("//button[contains(text() = 'No')]"));
            return btn_NODelete;
        }
        private static IWebElement DoNotSave(IWebDriver driver)
        {
            IWebElement btn_DoNotSave = driver.FindElement(By.XPath("//div[contains(text() = 'Do Not Save')]"));
            return btn_DoNotSave;
        }
        private static IWebElement Save(IWebDriver driver)
        {
            IWebElement btn_Save = driver.FindElement(By.XPath("//div[contains(text() = 'Save')]"));
            return btn_Save;
        }

        public static void TypePractice(IWebDriver driver, string practice)
        {
            ChoosePractice(driver).SendKeys(practice);
        }
        public static void TypeProvider(IWebDriver driver, string practice)
        {
            ChooseProvider(driver).SendKeys(practice);
        }
        public static void CheckNoPractice(IWebDriver driver)
        {
            if(!NoPractice(driver).Selected)
            {
                NoPractice(driver).Click();
            }
        }
        public static void UnCheckNoPractice(IWebDriver driver)
        {
            if(NoPractice(driver).Selected)
            {
                NoPractice(driver).Click();
            }
        }
        public static void CheckNoProvider(IWebDriver driver)
        {
            if(!NoProvider(driver).Selected)
            {
                NoProvider(driver).Click();
            }
        }
        public static void UnCheckNoProvider(IWebDriver driver)
        {
            if(NoProvider(driver).Selected)
            {
                NoProvider(driver).Click();
            }
        }
        public static void ClickSearchedItem(IWebDriver driver, string text)
        {
            FindSpantext(driver, text).Click();
        }
        public static void ClickFirstResult(IWebDriver driver)
        {
            SelectFirstPractice(driver).Click();
        }

        public static void ClickRecordsAdd(IWebDriver driver)
        {
            AddRecordbutton(driver).Click();
        }
        public static void ClickRecordsDropdown(IWebDriver driver)
        {
            AddRecorddropdown(driver).Click();
        }
        public static void ClickImagingAdd(IWebDriver driver)
        {
            AddImagingbutton(driver).Click();
        }
        public static void ClickImagingDropdown(IWebDriver driver)
        {
            AddImagingdropdown(driver).Click();
        }
        public static void ClickPathologyAdd(IWebDriver driver)
        {
            AddPathbutton(driver).Click();
        }
        public static void ClickPathologyDropdown(IWebDriver driver)
        {
            AddPathdropdown(driver).Click();
        }

        public static void TypeExplanation(IWebDriver driver, string text)
        {
            Explanation(driver).SendKeys(text);
        }

        public static void ClickCancel(IWebDriver driver)
        {
            Cancelbtn(driver).Click();
        }

        public static void ClickContinue(IWebDriver driver)
        {
            Continuebtn(driver).Click();
        }

        public static void ClickDontSave(IWebDriver driver)
        {
            DoNotSave(driver).Click();
        }

        public static void ClickSave(IWebDriver driver)
        {
            Save(driver).Click();
        }
    }
}