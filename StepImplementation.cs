using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using netcore.template.Pages;

namespace netcore.template
{
    public class StepImplementation
    {
        public static IWebDriver _driver;
        private HashSet<char> _vowels;

        [Step("Use Browser <browser>")]
        public void UseBrowserChrome(string browser)
        {
            Environment.SetEnvironmentVariable("BROWSER", browser);
        }

        [Step("Initialize driver")]
        public void InitializeDriver()
        {
            string browser = "";
            _driver = DriverFactory.GetDriver(browser);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Step("Navigate to QA Next <url>","Navigate to Decisions <url>")]
        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [Step("Enter <email> to Login to QA Next")]
        public void GoToQANextPage(string email)
        {
            Login.EnterEmail(_driver, email);
			DataStoreFactory.ScenarioDataStore.Add("email",email);
        }

        [Step("Click Login")]
        public void ClickLogin()
        {
            Login.ClickLogin(_driver);
        }

        [Step("Enter Password <password>")]
        public void EnterPassword(string password)
        {
			string email = (string) DataStoreFactory.ScenarioDataStore.Get("email");
            Login.EnterPassword(_driver, email, password);
        }

        [Step("Verify User has logged in")]
        public void VerifyUserHasLoggedIn()
        {
            Dashboard.PageVerify(_driver);
        }

        [Step("Close Browser")]
        public void CloseBrowser()
        {
            _driver.Quit();
        }

		[Step("Click New Retrieval Request")]
		public void ClickNewRetrievalRequest()
		{
			Dashboard.ClickNewRetReq(_driver);
		}
	
		[Step("Enter Patient info to search by <patient>")]
		public void EnterPatientInfoToSearchBy(string patient)
		{
			Patient.TypeChoosePatient(_driver, patient);
			DataStoreFactory.ScenarioDataStore.Add("patient",patient);
		}
	
		[Step("Select Patient, Verify correct patient selected")]
		public void SelectPatientVerifyCorrectPatientSelected()
		{
			string patient = (string) DataStoreFactory.ScenarioDataStore.Get("patient");
			Patient.SelectNextMatch(_driver, patient);
            CommonOBJs.VerifyText(_driver, patient);
		}
	
		[Step("Click Continue")]
		public void ClickContinue()
		{
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Select Department <dept>")]
		public void SelectDepartment(string dept)
		{
			RetrievalRequestInfo.SelectDepartment(_driver, dept);
			DataStoreFactory.ScenarioDataStore.Add("dept",dept);
		}

        [Step("Verify Dept")]
		public void VerifyDept()
		{
			string dept = (string) DataStoreFactory.ScenarioDataStore.Get("dept");
			CommonOBJs.VerifyText(_driver, dept);
		}

		[Step("Select Referral <referral>")]
		public void SelectReferral(string referral)
		{
			RetrievalRequestInfo.SelectReferralReason(_driver, referral);
			DataStoreFactory.ScenarioDataStore.Add("referral",referral);
		}
	
		[Step("Verify Referral")]
		public void VerifyReferral()
		{
			string referral = (string) DataStoreFactory.ScenarioDataStore.Get("referral");
			CommonOBJs.VerifyText(_driver, referral);
		}

		[Step("Select Insurance <insurance>")]
		public void SelectInsurance(string insurance)
		{
			RetrievalRequestInfo.SelectInsuranceProvider(_driver, insurance);
			DataStoreFactory.ScenarioDataStore.Add("insurance",insurance);
		}
	
		[Step("Verify Insurance")]
		public void VerifyInsurance()
		{
			string insurance = (string) DataStoreFactory.ScenarioDataStore.Get("insurance");
			CommonOBJs.VerifyText(_driver, insurance);
		}

		[Step("Click Cancel")]
		public void ClickCancel()
		{
			CommonOBJs.ClickCancel(_driver);
		}
	
		[Step("Click Continue to confirm patient")]
		public void ClickContinueToConfirmPatient()
		{
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Click Cancel on Request confirmation screen")]
		public void ClickCancelOnRequestConfirmationScreen()
		{
			CommonOBJs.ClickCancel(_driver);
		}
	
		[Step("Click Continue on Referral Confirmation")]
		public void ClickContinueOnReferralConfirmation()
		{
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Enter Date for Records <date>")]
		public void EnterDateForRecords(string date)
		{
			BeginRetrieval.TypeRecordNeedByDate(_driver, date);
			DataStoreFactory.ScenarioDataStore.Add("date",date);
		}
	
		[Step("Select Records Needed For <reason>")]
		public void SelectRecordsNeededFor(string reason)
		{
			BeginRetrieval.SelectRecordsNeedFor(_driver, reason);
			DataStoreFactory.ScenarioDataStore.Add("reason",reason);
		}
	
		[Step("Select Authorizing Physician <phys>")]
		public void SelectAuthorizingPhysician(string phys)
		{
			BeginRetrieval.SelectAuthPhys(_driver, phys);
			DataStoreFactory.ScenarioDataStore.Add("phys",phys);
		}
	
		[Step("Select Purpose of Request <Medical>")]
		public void SelectPurposeOfRequest(string purpose)
		{
			BeginRetrieval.SelectPurposeReq(_driver, purpose);
			DataStoreFactory.ScenarioDataStore.Add("purpose",purpose);
		}
	
		[Step("Select Checkbox for Patient Auth. <chkd>")]
		public void SelectCheckboxForPatientAuth(string chkd)
		{
			switch (chkd)
            {
                case "not available":
                {
                    BeginRetrieval.CheckNOPatientAuthAvail(_driver);
                    break;
                }
                case "available":
                {
                    BeginRetrieval.CheckPatientAuthAvail(_driver);
                    break;
                }
                default:break;
            }
		}
	
		[Step("Click Continue on Begin Retrieval request")]
		public void ClickContinueOnBeginRetrievalRequest()
		{
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Click Continue on Upload Files")]
		public void ClickContinueOnUploadFiles()
		{
			UploadFiles.VerifyFileZone(_driver);
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Enter Practice <practice>")]
		public void EnterPractice(string practice)
		{
			SelectProvider.TypePractice(_driver, practice);
			SelectProvider.ClickFirstResult(_driver);
			DataStoreFactory.ScenarioDataStore.Add("practice",practice);
		}
	
		[Step("Enter Provider <provider>")]
		public void EnterProvider(string provider)
		{
			SelectProvider.TypeProvider(_driver, provider);
			SelectProvider.ClickFirstResult(_driver);
			DataStoreFactory.ScenarioDataStore.Add("provider",provider);
		}
	
		[Step("Select Record template <record>")]
		public void SelectRecordTemplate(string record)
		{
			SelectProvider.ClickRecordsDropdown(_driver);
			CommonOBJs.ClickText(_driver, record);
			DataStoreFactory.ScenarioDataStore.Add("record",record);
		}
	
		[Step("Select Imaging template <image>")]
		public void SelectImagingTemplate(string image)
		{
			SelectProvider.ClickImagingDropdown(_driver);
			CommonOBJs.ClickText(_driver, image);
			DataStoreFactory.ScenarioDataStore.Add("image",image);
		}
	
		[Step("Select Pathology template <path>")]
		public void SelectPathologyTemplate(string path)
		{
			SelectProvider.ClickPathologyDropdown(_driver);
			CommonOBJs.ClickText(_driver, path);
			DataStoreFactory.ScenarioDataStore.Add("path",path);
		}
	
		[Step("Enter Explanation <text>")]
		public void EnterExplanation(string text)
		{
			SelectProvider.TypeExplanation(_driver, text);
			DataStoreFactory.ScenarioDataStore.Add("text",text);
		}
	
		[Step("Click Continue on Select Provider")]
		public void ClickContinueOnSelectProvider()
		{
			CommonOBJs.ClickContinue(_driver);
		}
	
		[Step("Verify request information")]
		public void VerifyRequestInformation()
		{
			//string date = (string) DataStoreFactory.ScenarioDataStore.Get("date");
			string practice = (string) DataStoreFactory.ScenarioDataStore.Get("practice");
			//string provider = (string) DataStoreFactory.ScenarioDataStore.Get("provider");
			string purpose = (string) DataStoreFactory.ScenarioDataStore.Get("purpose");
			string reason = (string) DataStoreFactory.ScenarioDataStore.Get("reason");
			string phys = (string) DataStoreFactory.ScenarioDataStore.Get("phys");
			string text = (string) DataStoreFactory.ScenarioDataStore.Get("text");

			//CommonOBJs.VerifyText(_driver,date);
			//CommonOBJs.VerifyText(_driver,practice);
			//CommonOBJs.VerifyText(_driver,provider);
			CommonOBJs.VerifyText(_driver,purpose);
			CommonOBJs.VerifyText(_driver,reason.ToLower());
			CommonOBJs.VerifyText(_driver,phys);
			CommonOBJs.VerifyText(_driver,text.ToString());
		}
	
		[Step("Click Cancel on Select Provider")]
		public void ClickCancelOnSelectProvider()
		{
			SelectProvider.ClickCancel(_driver);
		}
	
		[Step("Check No Provider checkbox")]
		public void CheckNoProviderCheckbox()
		{
			SelectProvider.CheckNoProvider(_driver);
		}
	
		[Step("Step through All Patient table to find <name> and click Recycle")]
		public void StepThroughAllPatientTableToFindAndClickRecycle(string name)
		{
			Dashboard.ClickRecycleSelectPatient(_driver, name);
		}
	
		[Step("Step through Recycle Bin and delete all <name> requests")]
		public void StepThroughRecycleBinAndDeleteAllRequests(string name)
		{
			Dashboard.ClickDeletePatientRecBin(_driver, name);
		}
	
		[Step("Click Recycle bin tab")]
		public void ClickRecycleBinTab()
		{
			Dashboard.ClickRecycleBin(_driver);
		}
	
		[Step("Enter <username> into Decisions username field")]
		public void EnterIntoDecisionsUsernameField(string username)
		{
			Login_Decisions.EnterEmail(_driver, username);
		}
	
		[Step("Enter <password> into Decisions Password")]
		public void EnterIntoDecisionsPassword(string password)
		{
			Login_Decisions.EnterPassword(_driver, password);
		}
	
		[Step("Click Decisions Login")]
		public void ClickDecisionsLogin()
		{
			Login_Decisions.ClickLogin(_driver);
		}
	
		[Step("Verify User has logged into Decisions")]
		public void VerifyUserHasLoggedIntoDecisions()
		{
			PatientDemoDash.PageVerify(_driver);
		}
	
		[Step("Right Click first <report> from Report Viewer table")]
		public void ClickFirstRegionFromReportViewerTable(string report)
		{
			string fax = PatientDemoDash.GetFaxNumatSelecteddemo(_driver, report);
			PatientDemoDash.ClickFirstRegionByText(_driver, report);
			DataStoreFactory.ScenarioDataStore.Add("faxnum",fax);
		}
	
		[Step("Click Perform Demo")]
		public void ClickPerformDemo()
		{
			PatientDemoDash.ClickPerformDemo(_driver);
		}
	
		[Step("Enter <patient> into Patient Name field")]
		public void EnterIntoPatientNameField(string patient)
		{
			ReportDemo.EnterPatientName(_driver, patient);
			DataStoreFactory.ScenarioDataStore.Add("patient",patient);
		}
	
		[Step("Click Search on Report Demo")]
		public void ClickSearchOnReportDemo()
		{
			ReportDemo.ClickSearchPatient(_driver);
		}
	
		[Step("Select first Table row for Potential Cases")]
		public void SelectFirstTableRowForPotentialCases()
		{
			string text = (string) DataStoreFactory.ScenarioDataStore.Get("patient");
			ReportDemo.ClickFirstPatientCase(_driver, text);
		}
	
		[Step("Verify Data populates Facility Location dropdown")]
		public void VerifyDataPopulatesFacilityLocationDropdown()
		{
			ReportDemo.VerifyFacilityLocationsExist(_driver);
		}
	
		[Step("Click Return to Queue")]
		public void ClickReturnToQueue()
		{
			ReportDemo.ClickReturntoQueue(_driver);
		}
	
		[Step("Select Facility Location")]
		public void SelectFacilityLocation()
		{
			ReportDemo.ClickFacilityLocationDropDown(_driver);
			ReportDemo.ClickFirstFacilityLoc(_driver);
		}
	
		[Step("Add CSS note")]
		public void AddCSSNote()
		{
			ReportDemo.ClickAddCSSNote(_driver);
			ReportDemo.TypeNote(_driver, "Hello world");
			ReportDemo.ClickAddNote_popup(_driver);
		}
	
		[Step("Select Approve")]
		public void SelectApprove()
		{
			ReportDemopg2.ClickApprove(_driver);
		}
	
		[Step("Verify Demo on Review dashboard")]
		public void VerifyDemoOnReviewDashboard()
		{
			string text = (string) DataStoreFactory.ScenarioDataStore.Get("faxnum");
			PatientDemoDash.GetFaxNum(_driver,text);
		}
	
		[Step("Verify Demo appears in Exception dashboard")]
		public void VerifyDemoAppearsInExceptionDashboard()
		{
			string text = (string) DataStoreFactory.ScenarioDataStore.Get("faxnum");
			PatientDemoDash.GetFaxNum(_driver,text);
		}
	
		[Step("Click Exception")]
		public void ClickException()
		{
			ReportDemo.ClickException(_driver);
		}
	
		[Step("Click Exception Dashboard tab")]
		public void ClickExceptionDashboardTab()
		{
			PatientDemoDash.ClickExceptionDemoDashTab(_driver);
		}
	
		[Step("Click Review dashboard tab")]
		public void ClickReviewDashboardTab()
		{
			//ReportDemo.ClickComplete(_driver);
			
			PatientDemoDash.ClickReviewDemoDashTab(_driver);
		}
	
		[Step("Click Send to Exception")]
		public void ClickSendToException()
		{
			ReportDemo.ClickSendExceptionReason(_driver);
		}
	
		[Step("Select Exception Reason")]
		public void SelectExceptionReason()
		{
			ReportDemo.ClickExceptionReasonDropArrow(_driver);
			ReportDemo.ClickFirstExceptionReason(_driver);
		}
	
		[Step("Verify Demo on Patient Demo dashboard")]
		public void VerifyDemoOnPatientDemoDashboard()
		{
			string text = (string) DataStoreFactory.ScenarioDataStore.Get("faxnum");
			PatientDemoDash.GetFaxNum(_driver,text);		
		}
	
		[Step("Click Next button")]
		public void ClickNextButton()
		{
			ReportDemo.ClickNext(_driver);
		}
	
		[Step("Click CSS Attention")]
		public void ClickCssAttention()
		{
			ReportDemopg2.ClickCSSAttention(_driver);
		}
	
		[Step("Click Review Exception")]
		public void ClickReviewException()
		{
			PatientDemoDash.ClickReviewException(_driver);
		}
	}
}
