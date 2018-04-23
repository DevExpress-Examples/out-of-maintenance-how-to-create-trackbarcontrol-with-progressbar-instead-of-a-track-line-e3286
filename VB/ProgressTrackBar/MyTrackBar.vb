Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace WindowsFormsApplication1
	Friend Class MyTrackBar
		Inherits TrackBarControl
		Shared Sub New()
			MyRepositoryItemTrackBar.Register()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyRepositoryItemTrackBar.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As MyRepositoryItemTrackBar
			Get
				Return TryCast(MyBase.Properties, MyRepositoryItemTrackBar)
			End Get
		End Property

	End Class

End Namespace
