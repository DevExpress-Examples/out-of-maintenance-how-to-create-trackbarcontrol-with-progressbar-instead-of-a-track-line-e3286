Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace ProgressTrackBar
	Partial Public Class Form1
		Inherits Form
		Private prb As ProgressBarControl
		Public Sub New()
            prb = New ProgressBarControl()
            InitializeComponent()
            prb.Position = 50
		End Sub

		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
			progressBarControl1.Position = trackBarControl1.Value
			prb.Position = trackBarControl1.Value
		End Sub

		Private Sub checkButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkButton1.CheckedChanged
			If checkButton1.Checked Then
				myTrackBar1.Properties.Progress = prb
			Else
				myTrackBar1.Properties.Progress = Nothing
			End If
		End Sub

	End Class
End Namespace