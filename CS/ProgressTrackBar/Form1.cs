using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProgressTrackBar
{
    public partial class Form1 : Form
    {
        ProgressBarControl prb;
        public Form1()
        {
            InitializeComponent();
            prb = new ProgressBarControl();
            prb.Position = 50;
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            progressBarControl1.Position = trackBarControl1.Value;
            prb.Position = trackBarControl1.Value;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
                myTrackBar1.Properties.Progress = prb;
            else
                myTrackBar1.Properties.Progress = null;
        }

    }
}