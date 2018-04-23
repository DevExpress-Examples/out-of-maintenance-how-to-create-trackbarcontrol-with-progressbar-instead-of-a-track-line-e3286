using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace WindowsFormsApplication1
{
    class MyTrackBar : TrackBarControl
    {
        static MyTrackBar()
        {
            MyRepositoryItemTrackBar.Register();
        }
        public override string EditorTypeName
        {
            get { return MyRepositoryItemTrackBar.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new MyRepositoryItemTrackBar Properties
        {
            get { return base.Properties as MyRepositoryItemTrackBar; }
        }

    }

}
