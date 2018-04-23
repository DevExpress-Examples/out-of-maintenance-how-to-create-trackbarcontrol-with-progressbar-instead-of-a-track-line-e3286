using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication1
{
    class MyTrackBarViewInfo : TrackBarViewInfo
    {
        public MyTrackBarViewInfo(RepositoryItem item)
            : base(item)
        {

        }
        public override TrackBarObjectPainter GetTrackPainter()
        {
            if (IsPrinting)
                return new TrackBarObjectPainter();
            if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.WindowsXP)
                return new WindowsXPTrackBarObjectPainter();
            if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                return new MySkinTrackBarObjectPainter(LookAndFeel.ActiveLookAndFeel);
            if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Office2003)
                return new Office2003TrackBarObjectPainter();
            return new TrackBarObjectPainter();

        }

    }
}
