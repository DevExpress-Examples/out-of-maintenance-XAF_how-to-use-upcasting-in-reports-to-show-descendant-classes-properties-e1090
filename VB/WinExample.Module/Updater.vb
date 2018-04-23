Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.Persistent.BaseImpl

Namespace WinExample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			CreateReport("EmployeeBaseReport")
			Dim employee As EmployeeBase = ObjectSpace.CreateObject(Of EmployeeBase)()
			employee.Name = "Employee"
			employee.Email = "employee1@corp.com"
			Dim foreignEmployee As ForeignEmployee = ObjectSpace.CreateObject(Of ForeignEmployee)()
			foreignEmployee.Name = "Foreign Employee"
			foreignEmployee.Email = "employee2@corp.com"
			foreignEmployee.VisaExpirationDate = DateTime.Now.AddMonths(2)
			Dim localEmployee As LocalEmployee = ObjectSpace.CreateObject(Of LocalEmployee)()
			localEmployee.Name = "Local Employee"
			localEmployee.Email = "employee3@corp.com"
			localEmployee.InsurancePolicyNumber = "111-222-333"
		End Sub
		Private Sub CreateReport(ByVal reportName As String)
			Dim reportdata As ReportData = ObjectSpace.FindObject(Of ReportData)(New BinaryOperator("Name", reportName))
			If reportdata Is Nothing Then
				reportdata = ObjectSpace.CreateObject(Of ReportData)()
				Dim rep As New XafReport()
				rep.ReportName = reportName
				rep.ObjectSpace = ObjectSpace
				rep.LoadLayout(Me.GetType().Assembly.GetManifestResourceStream("EmbeddedReports." & reportName & ".repx"))
				reportdata.SaveReport(rep)
				reportdata.Save()
			End If
		End Sub
	End Class
End Namespace
