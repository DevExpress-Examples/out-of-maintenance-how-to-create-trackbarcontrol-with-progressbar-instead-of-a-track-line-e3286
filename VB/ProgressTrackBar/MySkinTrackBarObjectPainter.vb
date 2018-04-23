Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
	Friend Class MySkinTrackBarObjectPainter
		Inherits SkinTrackBarObjectPainter
		Public Sub New(ByVal provider As ISkinProvider)
			MyBase.New(provider)
		End Sub
		Protected Overrides Sub DrawLine(ByVal e As TrackBarObjectInfoArgs, ByVal p1 As System.Drawing.Point, ByVal p2 As System.Drawing.Point)
			MyBase.DrawLine(e, p1, p2)
		End Sub
		Public Overrides Sub DrawTrackLine(ByVal e As TrackBarObjectInfoArgs)
			Dim rec As Rectangle = e.ViewInfo.TrackBarHelper.Rotate(e.ViewInfo.TrackLineRect)
			rec.X = e.ViewInfo.PointsRect.X
			rec.Width = e.ViewInfo.PointsRect.Width

			Dim prb As ProgressBarControl = (TryCast(e.ViewInfo.Item, MyRepositoryItemTrackBar)).Progress
			If prb Is Nothing Then
				MyBase.DrawTrackLine(e)
				Return
			End If
			Dim vi As BaseControlViewInfo = prb.GetViewInfo()
			vi.CalcViewInfo(e.Graphics, MouseButtons.None, Point.Empty, rec)
			Dim args As New ControlGraphicsInfoArgs(vi, e.Cache, rec)
			vi.Painter.Draw(args)

		End Sub
	End Class
End Namespace
