Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Imports DevExpress.Persistent.Base

Namespace WinExample.Module
	<DefaultClassOptions> _
	Public Class LocalEmployee
		Inherits EmployeeBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private insurancePolicyNumber_Renamed As String
		Public Property InsurancePolicyNumber() As String
			Get
				Return insurancePolicyNumber_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("InsurancePolicyNumber", insurancePolicyNumber_Renamed, value)
			End Set
		End Property
	End Class

End Namespace
