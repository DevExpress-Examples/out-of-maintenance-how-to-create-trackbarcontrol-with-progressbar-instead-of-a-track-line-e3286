Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsFormsApplication1
	Friend Class MyRepositoryItemTrackBar
		Inherits RepositoryItemTrackBar
		Private _progress As ProgressBarControl
		Public Property Progress() As ProgressBarControl
			Get
				Return _progress
			End Get
			Set(ByVal value As ProgressBarControl)
				If _progress Is value Then
					Return
				End If
				If _progress IsNot Nothing Then
					RemoveHandler _progress.PropertiesChanged, AddressOf _progress_PropertiesChanged
					RemoveHandler _progress.EditValueChanged, AddressOf _progress_PropertiesChanged
				End If
				_progress = value
				If _progress IsNot Nothing Then
					AddHandler _progress.PropertiesChanged, AddressOf _progress_PropertiesChanged
					AddHandler _progress.EditValueChanged, AddressOf _progress_PropertiesChanged
				End If
				Me.OnPropertiesChanged(EventArgs.Empty)
			End Set
		End Property

		Private Sub _progress_PropertiesChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.OnPropertiesChanged(EventArgs.Empty)
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Friend Const EditorName As String = "MyTrackBar"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyTrackBar), GetType(MyRepositoryItemTrackBar), GetType(MyTrackBarViewInfo), New TrackBarPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Me.Progress = (TryCast(item, MyRepositoryItemTrackBar)).Progress
		End Sub
	End Class

End Namespace
