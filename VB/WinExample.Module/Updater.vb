Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp

Namespace WinExample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			CreateReport("EmployeeBaseReport")
			Dim employee As New EmployeeBase(Session)
			employee.Name = "Employee"
			employee.Email = "employee1@corp.com"
			employee.Save()
			Dim foreignEmployee As New ForeignEmployee(Session)
			foreignEmployee.Name = "Foreign Employee"
			foreignEmployee.Email = "employee2@corp.com"
			foreignEmployee.VisaExpirationDate = DateTime.Now.AddMonths(2)
			foreignEmployee.Save()
			Dim localEmployee As New LocalEmployee(Session)
			localEmployee.Name = "Local Employee"
			localEmployee.Email = "employee3@corp.com"
			localEmployee.InsurancePolicyNumber = "111-222-333"
			localEmployee.Save()
		End Sub
		Private Sub CreateReport(ByVal reportName As String)
			Dim reportdata As ReportData = Session.FindObject(Of ReportData)(New BinaryOperator("Name", reportName))
			If reportdata Is Nothing Then
				reportdata = New ReportData(Session)
				Dim rep As New XafReport()
				rep.ReportName = reportName
				rep.ObjectSpace = New ObjectSpace(New UnitOfWork(Session.DataLayer), XafTypesInfo.Instance)
				rep.LoadLayout(Me.GetType().Assembly.GetManifestResourceStream("EmbeddedReports." & reportName & ".repx"))
				reportdata.SaveXtraReport(rep)
				reportdata.Save()
			End If
		End Sub
	End Class
End Namespace
