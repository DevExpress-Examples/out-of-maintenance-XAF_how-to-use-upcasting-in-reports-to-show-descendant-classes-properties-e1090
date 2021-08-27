<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1090)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[script.txt](./CS/script.txt) (VB: [script.txt](./VB/script.txt))**
* [EmployeeBase.cs](./CS/WinExample.Module/EmployeeBase.cs) (VB: [EmployeeBase.vb](./VB/WinExample.Module/EmployeeBase.vb))
* [ForeignEmployee.cs](./CS/WinExample.Module/ForeignEmployee.cs) (VB: [ForeignEmployee.vb](./VB/WinExample.Module/ForeignEmployee.vb))
* [LocalEmployee.cs](./CS/WinExample.Module/LocalEmployee.cs) (VB: [LocalEmployee.vb](./VB/WinExample.Module/LocalEmployee.vb))
* [Model.DesignedDiffs.xafml](./CS/WinExample.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinExample.Module/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/WinExample.Module/Updater.cs) (VB: [Updater.vb](./VB/WinExample.Module/Updater.vb))
<!-- default file list end -->
# How to use UpCasting in reports to show descendant classes' properties


<p>In the XafApplication, there is the capability to show derived classes' properties in the ListView of the base class using the UpCasting feature. This example demonstrates, how to achieve the same results in XafReport using the BeforePrint script. The BeforePrint handler is called for each record printed in the report. The currently printed record is obtained via the XtraReport.GetCurrentRow method. Then, its type is checked and the text of the report labels is changed according to this type.</p><p>The sample report is stored in the *.repx file in the WinExample.Module\EmbeddedReports folder. It is loaded to the database in the UpdateDatabaseAfterUpdateSchema method. For your convenience, I have published the BeforePrint script from this report in a separate file (script.txt). This file is not used by the application.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2797"><u>How to: Use UpCasting</u></a><br />
<a href="http://documentation.devexpress.com/#XtraReports/CustomDocument2615"><u>Scripting Overview</u></a><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2786"><u>Distribute the Created Reports with the Application</u></a></p>

<br/>


