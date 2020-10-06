Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApp1.Models
	Partial Public Class Categories
		Public Sub New()
			Products = New HashSet(Of Products)()
		End Sub

		Public Property CategoryId() As Integer
		Public Property CategoryName() As String
		Public Property Description() As String
		Public Property Picture() As Byte()

		Public Overridable Property Products() As ICollection(Of Products)
	End Class
End Namespace
