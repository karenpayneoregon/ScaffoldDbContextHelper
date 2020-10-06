Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class Employees
		Public Sub New()
			Orders = New HashSet(Of Orders)()
		End Sub

		Public Property EmployeeId() As Integer
		Public Property LastName() As String
		Public Property FirstName() As String
		Public Property Title() As String
		Public Property TitleOfCourtesy() As String
		Public Property BirthDate() As DateTime?
		Public Property HireDate() As DateTime?
		Public Property Address() As String
		Public Property City() As String
		Public Property Region() As String
		Public Property PostalCode() As String
		Public Property Country() As String
		Public Property HomePhone() As String
		Public Property Extension() As String
		Public Property Photo() As Byte()
		Public Property Notes() As String
		Public Property ReportsTo() As Integer?

		Public Overridable Property Orders() As ICollection(Of Orders)
	End Class
End Namespace
