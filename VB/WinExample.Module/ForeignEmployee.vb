Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinExample.Module
	<DefaultClassOptions> _
	Public Class ForeignEmployee
		Inherits EmployeeBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private visaExpirationDate_Renamed As DateTime
		Public Property VisaExpirationDate() As DateTime
			Get
				Return visaExpirationDate_Renamed
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("VisaExpirationDate", visaExpirationDate_Renamed, value)
			End Set
		End Property
	End Class

End Namespace
