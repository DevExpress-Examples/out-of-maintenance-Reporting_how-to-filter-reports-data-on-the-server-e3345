Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
' ...

Namespace ServerParams
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonShow.Click
			Dim report As New ProductReport()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
