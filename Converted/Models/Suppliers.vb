Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class Suppliers
		Public Property SupplierId() As Integer
		Public Property CompanyName() As String
		Public Property ContactName() As String
		Public Property ContactTitle() As String
		Public Property SuppliersTitleId() As Integer?
		Public Property Address() As String
		Public Property City() As String
		Public Property Region() As String
		Public Property PostalCode() As String
		Public Property Country() As String
		Public Property Phone() As String
		Public Property Fax() As String
		Public Property HomePage() As String

		Public Overridable Property SuppliersTitle() As SuppliersContactTitle
	End Class
End Namespace
