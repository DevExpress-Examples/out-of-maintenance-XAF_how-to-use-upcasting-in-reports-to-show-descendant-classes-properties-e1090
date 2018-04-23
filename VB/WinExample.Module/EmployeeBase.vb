Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinExample.Module
	<DefaultClassOptions> _
	Public Class EmployeeBase
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private name_Renamed As String
		Private email_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", name_Renamed, value)
			End Set
		End Property
		Public Property Email() As String
			Get
				Return email_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Email", email_Renamed, value)
			End Set
		End Property
	End Class

End Namespace
