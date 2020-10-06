Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class Customers
		Public Sub New()
			Orders = New HashSet(Of Orders)()
		End Sub

		Public Property CustomerId() As String
		Public Property Identifier() As Integer
		Public Property CompanyName() As String
		Public Property ContactName() As String
		Public Property ContactTitle() As String
		Public Property ContactTitleId() As Integer?
		Public Property Address() As String
		Public Property City() As String
		Public Property Region() As String
		Public Property PostalCode() As String
		Public Property Country() As String
		Public Property Phone() As String
		Public Property Fax() As String

		Public Overridable Property ContactTitleNavigation() As CustomersContactTitle
		Public Overridable Property Orders() As ICollection(Of Orders)
	End Class
End Namespace
