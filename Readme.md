# How to use UpCasting in reports to show descendant classes' properties


<p>In the XafApplication, there is the capability to show derived classes' properties in the ListView of the base class using the UpCasting feature. This example demonstrates, how to achieve the same results in XafReport using the BeforePrint script. The BeforePrint handler is called for each record printed in the report. The currently printed record is obtained via the XtraReport.GetCurrentRow method. Then, its type is checked and the text of the report labels is changed according to this type.</p><p>The sample report is stored in the *.repx file in the WinExample.Module\EmbeddedReports folder. It is loaded to the database in the UpdateDatabaseAfterUpdateSchema method. For your convenience, I have published the BeforePrint script from this report in a separate file (script.txt). This file is not used by the application.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2797"><u>How to: Use UpCasting</u></a><br />
<a href="http://documentation.devexpress.com/#XtraReports/CustomDocument2615"><u>Scripting Overview</u></a><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2786"><u>Distribute the Created Reports with the Application</u></a></p>

<br/>


