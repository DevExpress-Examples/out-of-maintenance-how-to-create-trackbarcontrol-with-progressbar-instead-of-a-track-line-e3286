using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;

namespace WindowsFormsApplication1
{
    class MyRepositoryItemTrackBar : RepositoryItemTrackBar
    {
        ProgressBarControl _progress;
        public ProgressBarControl Progress
        {
            get { return _progress; }
            set
            {
                if (_progress == value)
                    return;
                if (_progress != null)
                {
                    _progress.PropertiesChanged -= new EventHandler(_progress_PropertiesChanged);
                    _progress.EditValueChanged -= new EventHandler(_progress_PropertiesChanged);
                }
                _progress = value;
                if (_progress != null)
                {
                    _progress.PropertiesChanged += new EventHandler(_progress_PropertiesChanged);
                    _progress.EditValueChanged += new EventHandler(_progress_PropertiesChanged);
                }
                this.OnPropertiesChanged(EventArgs.Empty);
            }
        }

        void _progress_PropertiesChanged(object sender, EventArgs e)
        {
            this.OnPropertiesChanged(EventArgs.Empty);
        }

        public MyRepositoryItemTrackBar()
            : base()
        {
        }

        internal const string EditorName = "MyTrackBar";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyTrackBar),
                typeof(MyRepositoryItemTrackBar), typeof(MyTrackBarViewInfo),
                new TrackBarPainter(), true));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }
        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            this.Progress = (item as MyRepositoryItemTrackBar).Progress;
        }
    }

}
