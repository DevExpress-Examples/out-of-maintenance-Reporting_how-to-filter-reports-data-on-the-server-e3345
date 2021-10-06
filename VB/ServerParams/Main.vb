Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

' ...
Namespace ServerParams

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub buttonShow_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As ProductReport = New ProductReport()
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
