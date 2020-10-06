Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class SuppliersContactTitle
		Public Sub New()
			Suppliers = New HashSet(Of Suppliers)()
		End Sub

		Public Property SuppliersTitleId() As Integer
		Public Property Title() As String

		Public Overridable Property Suppliers() As ICollection(Of Suppliers)
	End Class
End Namespace
