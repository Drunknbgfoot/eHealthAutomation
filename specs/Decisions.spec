Decisions Regression
=====================
Created by cory.campbell on 11/13/2019 3:00:01 PM.

table: C:\Users\cory.campbell\source\repos\GaugeVSCode_test\Decisions_Data.csv

* Use Browser <browser>
* Initialize driver

## Return to Queue

* Navigate to Decisions <url>
* Enter <username> into Decisions username field
* Enter <password> into Decisions Password
* Click Decisions Login
* Verify User has logged into Decisions
* Right Click first "Patient Demo" from Report Viewer table
* Click Perform Demo
* Enter <patientname> into Patient Name field
* Click Search on Report Demo
* Select first Table row for Potential Cases
* Verify Data populates Facility Location dropdown
* Click Return to Queue
* Verify Demo on Patient Demo dashboard

## Approve Demo

* Navigate to Decisions <url>
* Enter <username> into Decisions username field
* Enter <password> into Decisions Password
* Click Decisions Login
* Right Click first "Patient Demo" from Report Viewer table
* Click Perform Demo
* Enter <patientname> into Patient Name field
* Click Search on Report Demo
* Select first Table row for Potential Cases
* Verify Data populates Facility Location dropdown
* Select Facility Location
* Click Next button
* Click CSS Attention
* Select Approve
* Click Review dashboard tab
* Verify Demo on Review dashboard

## Exception Demo

* Navigate to Decisions <url>
* Enter <username> into Decisions username field
* Enter <password> into Decisions Password
* Click Decisions Login
* Right Click first "Patient Demo" from Report Viewer table
* Click Perform Demo
* Enter <patientname> into Patient Name field
* Click Search on Report Demo
* Select first Table row for Potential Cases
* Verify Data populates Facility Location dropdown
* Click Exception
* Select Exception Reason
* Click Send to Exception
* Click Exception Dashboard tab
* Verify Demo appears in Exception dashboard

## Exception Approval

* Navigate to Decisions <url>
* Enter <username> into Decisions username field
* Enter <password> into Decisions Password
* Click Decisions Login
* Click Exception Dashboard tab
* Right Click first "Patient Not Found" from Report Viewer table
* Click Review Exception
* Enter <patientname> into Patient Name field
* Click Search on Report Demo
* Select first Table row for Potential Cases
* Verify Data populates Facility Location dropdown
* Select Facility Location
* Click Next button
* Click CSS Attention
* Select Approve
* Click Review dashboard tab
* Verify Demo on Review dashboard

______________________
* Close Browser
