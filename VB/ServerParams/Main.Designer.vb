Imports Microsoft.VisualBasic
Imports System
Namespace ServerParams
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.buttonShow = New DevExpress.XtraEditors.SimpleButton()
			Me.SuspendLayout()
			' 
			' buttonShow
			' 
			Me.buttonShow.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonShow.Location = New System.Drawing.Point(12, 12)
			Me.buttonShow.Name = "buttonShow"
			Me.buttonShow.Size = New System.Drawing.Size(252, 69)
			Me.buttonShow.TabIndex = 0
			Me.buttonShow.Text = "Show Report"
'			Me.buttonShow.Click += New System.EventHandler(Me.buttonShow_Click);
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(276, 93)
			Me.Controls.Add(Me.buttonShow)
			Me.Name = "Main"
			Me.Text = "Server Parameter Example"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents buttonShow As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

