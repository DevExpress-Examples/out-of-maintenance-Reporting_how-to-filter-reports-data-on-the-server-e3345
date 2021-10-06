Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Namespace ServerParams

    Public Partial Class ProductReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ProductReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As ParametersRequestEventArgs)
            If Parameters("CategoryID") IsNot Nothing Then productsTableAdapter.FillByCategoryID(northwind1.Products, CInt(Parameters(CStr("CategoryID")).Value))
        End Sub
    End Class
End Namespace
