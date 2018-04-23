Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Namespace ServerParams
	Partial Public Class ProductReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
			If Parameters("CategoryID") IsNot Nothing Then
				productsTableAdapter.FillByCategoryID(northwind1.Products, CInt(Fix(Parameters("CategoryID").Value)))
			End If
		End Sub

	End Class
End Namespace
