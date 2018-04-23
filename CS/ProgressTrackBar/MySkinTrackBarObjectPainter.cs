using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Skins;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MySkinTrackBarObjectPainter : SkinTrackBarObjectPainter
    {
        public MySkinTrackBarObjectPainter(ISkinProvider provider) : base(provider) { }
        protected override void DrawLine(TrackBarObjectInfoArgs e, System.Drawing.Point p1, System.Drawing.Point p2)
        {
            base.DrawLine(e, p1, p2);
        }
        public override void DrawTrackLine(TrackBarObjectInfoArgs e)
        {
            Rectangle rec = e.ViewInfo.TrackBarHelper.Rotate(e.ViewInfo.TrackLineRect);
            rec.X = e.ViewInfo.PointsRect.X;
            rec.Width = e.ViewInfo.PointsRect.Width;

            ProgressBarControl prb = (e.ViewInfo.Item as MyRepositoryItemTrackBar).Progress;
            if (prb == null)
            {
                base.DrawTrackLine(e);
                return;
            }
            BaseControlViewInfo vi = prb.GetViewInfo();
            vi.CalcViewInfo(e.Graphics, MouseButtons.None, Point.Empty, rec);
            ControlGraphicsInfoArgs args = new ControlGraphicsInfoArgs(vi, e.Cache, rec);
            vi.Painter.Draw(args);

        }
    }
}
