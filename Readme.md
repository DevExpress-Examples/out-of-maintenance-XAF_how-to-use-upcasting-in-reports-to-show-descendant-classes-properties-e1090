<!-- default file list -->
*Files to look at*:

* **[script.txt](./CS/script.txt) (VB: [script.txt](./VB/script.txt))**
* [Model.DesignedDiffs.xafml](./CS/WinExample.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinExample.Module.Win/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/WinExample.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/WinExample.Module.Win/Updater.vb))
* [WinModule.cs](./CS/WinExample.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/WinExample.Module.Win/WinModule.vb))
* [EmployeeBase.cs](./CS/WinExample.Module/EmployeeBase.cs) (VB: [EmployeeBase.vb](./VB/WinExample.Module/EmployeeBase.vb))
* [ForeignEmployee.cs](./CS/WinExample.Module/ForeignEmployee.cs) (VB: [ForeignEmployee.vb](./VB/WinExample.Module/ForeignEmployee.vb))
* [LocalEmployee.cs](./CS/WinExample.Module/LocalEmployee.cs) (VB: [LocalEmployee.vb](./VB/WinExample.Module/LocalEmployee.vb))
* [Model.DesignedDiffs.xafml](./CS/WinExample.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinExample.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/WinExample.Module/Module.cs) (VB: [Module.vb](./VB/WinExample.Module/Module.vb))
* [Updater.cs](./CS/WinExample.Module/Updater.cs) (VB: [Updater.vb](./VB/WinExample.Module/Updater.vb))
* [Model.xafml](./CS/WinExample.Win/Model.xafml) (VB: [Model.xafml](./VB/WinExample.Win/Model.xafml))
* [Program.cs](./CS/WinExample.Win/Program.cs) (VB: [Program.vb](./VB/WinExample.Win/Program.vb))
* [WinApplication.cs](./CS/WinExample.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/WinExample.Win/WinApplication.vb))
<!-- default file list end -->
# How to use UpCasting in reports to show descendant classes' properties


<p>In the XafApplication, there is the capability to show derived classes' properties in the ListView of the base class using the UpCasting feature. This example demonstrates, how to achieve the same results in XafReport using the BeforePrint script. The BeforePrint handler is called for each record printed in the report. The currently printed record is obtained via the XtraReport.GetCurrentRow method. Then, its type is checked and the text of the report labels is changed according to this type.</p><p>The sample report is stored in the *.repx file in the WinExample.Module\EmbeddedReports folder. It is loaded to the database in the UpdateDatabaseAfterUpdateSchema method. For your convenience, I have published the BeforePrint script from this report in a separate file (script.txt). This file is not used by the application.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2797"><u>How to: Use UpCasting</u></a><br />
<a href="http://documentation.devexpress.com/#XtraReports/CustomDocument2615"><u>Scripting Overview</u></a><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2786"><u>Distribute the Created Reports with the Application</u></a></p>

<br/>


