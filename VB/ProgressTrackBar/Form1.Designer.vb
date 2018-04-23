Imports Microsoft.VisualBasic
Imports System
Namespace ProgressTrackBar
	Partial Public Class Form1
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
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.myTrackBar1 = New WindowsFormsApplication1.MyTrackBar()
			Me.checkButton1 = New DevExpress.XtraEditors.CheckButton()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTrackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.trackBarControl1.EditValue = 50
			Me.trackBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.Maximum = 100
			Me.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None
			Me.trackBarControl1.Size = New System.Drawing.Size(284, 45)
			Me.trackBarControl1.TabIndex = 0
			Me.trackBarControl1.Value = 50
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.progressBarControl1.EditValue = 50
			Me.progressBarControl1.Location = New System.Drawing.Point(0, 90)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(284, 18)
			Me.progressBarControl1.TabIndex = 1
			' 
			' myTrackBar1
			' 
			Me.myTrackBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.myTrackBar1.EditValue = Nothing
			Me.myTrackBar1.Location = New System.Drawing.Point(0, 45)
			Me.myTrackBar1.Name = "myTrackBar1"
			Me.myTrackBar1.Properties.Progress = Nothing
			Me.myTrackBar1.Size = New System.Drawing.Size(284, 45)
			Me.myTrackBar1.TabIndex = 2
			' 
			' checkButton1
			' 
			Me.checkButton1.Location = New System.Drawing.Point(13, 115)
			Me.checkButton1.Name = "checkButton1"
			Me.checkButton1.Size = New System.Drawing.Size(119, 23)
			Me.checkButton1.TabIndex = 3
			Me.checkButton1.Text = "Use ProgressBar"
'			Me.checkButton1.CheckedChanged += New System.EventHandler(Me.checkButton1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.checkButton1)
			Me.Controls.Add(Me.progressBarControl1)
			Me.Controls.Add(Me.myTrackBar1)
			Me.Controls.Add(Me.trackBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTrackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private myTrackBar1 As WindowsFormsApplication1.MyTrackBar
		Private WithEvents checkButton1 As DevExpress.XtraEditors.CheckButton
	End Class
End Namespace

