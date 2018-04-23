Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication1
	Friend Class MyTrackBarViewInfo
		Inherits TrackBarViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)

		End Sub
		Public Overrides Function GetTrackPainter() As TrackBarObjectPainter
			If IsPrinting Then
				Return New TrackBarObjectPainter()
			End If
			If Me.LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.WindowsXP Then
				Return New WindowsXPTrackBarObjectPainter()
			End If
			If Me.LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
				Return New MySkinTrackBarObjectPainter(LookAndFeel.ActiveLookAndFeel)
			End If
			If Me.LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Office2003 Then
				Return New Office2003TrackBarObjectPainter()
			End If
			Return New TrackBarObjectPainter()

		End Function

	End Class
End Namespace
