QA Next
====================

* Use Browser "chrome"
* Initialize driver

Create New Retrieval request
---------------------
* Navigate to "https://qncust1-fe.azurewebsites.net/" and Login as user "qnc1-autointake@ehealth-record.com" with "Kick8Thy"
* Click New Retrieval Request
* Enter Patient info to search by "Mabel Rivera"
* Select Patient, Verify correct patient selected
* Click Continue to confirm patient
* Select Department "RMS v3 QN-Cust 1 Dept Eta"
* Select Referral "First Opinion"
* Select Insurance "Acme Insurance"
* Click Continue
* Verify Dept
* Verify Referral
* Verify Insurance
* Click Continue on Referral Confirmation
* Enter Date for Records "01/01/2030"
* Select Records Needed For "Appointment"
* Select Authorizing Physician "Dr. Doctor Oncology"
* Select Purpose of Request "Medical"
* Select Checkbox for Patient Auth. "not available"
* Click Continue on Begin Retrieval request
* Click Continue on Upload Files
* Enter Practice "Mad Science"
* Check No Provider checkbox
* Select Record template "Super Useful Records Template"
* Select Imaging template "Customer Imaging Template"
* Select Pathology template "Customer Pathology Template"
* Enter Explanation "This is why we cant have nice things"
* Click Continue on Select Provider
* Verify request information
* Click Cancel on Select Provider

Cleanup Steps
---------------------

* Navigate to "https://qncust1-fe.azurewebsites.net/" and Login as user "qnc1-autointake@ehealth-record.com" with "Kick8Thy"
* Step through All Patient table to find "Mabel Rivera" and click Recycle
* Click Recycle bin tab
* Step through Recycle Bin and delete all "Mabel Rivera" requests

_____________________
* Close Browser