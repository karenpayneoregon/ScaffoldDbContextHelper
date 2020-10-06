Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class Orders
		Public Property OrderId() As Integer
		Public Property Identifier() As Integer?
		Public Property CustomerIdOld() As String
		Public Property EmployeeId() As Integer?
		Public Property OrderDate() As DateTime?
		Public Property RequiredDate() As DateTime?
		Public Property ShippedDate() As DateTime?
		Public Property ShipVia() As Integer?
		Public Property Freight() As Decimal?
		Public Property ShipName() As String
		Public Property ShipAddress() As String
		Public Property ShipCity() As String
		Public Property ShipRegion() As String
		Public Property ShipPostalCode() As String
		Public Property ShipCountry() As String

		Public Overridable Property CustomerIdOldNavigation() As Customers
		Public Overridable Property Employee() As Employees
	End Class
End Namespace
