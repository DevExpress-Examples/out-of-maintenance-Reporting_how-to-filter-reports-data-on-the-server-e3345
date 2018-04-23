Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace ServerParams
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonShow.Click
			Dim report As New ProductReport()
			report.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
