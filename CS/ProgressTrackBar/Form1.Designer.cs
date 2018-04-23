namespace ProgressTrackBar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.myTrackBar1 = new WindowsFormsApplication1.MyTrackBar();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarControl1.EditValue = 50;
            this.trackBarControl1.Location = new System.Drawing.Point(0, 0);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.Maximum = 100;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl1.Size = new System.Drawing.Size(284, 45);
            this.trackBarControl1.TabIndex = 0;
            this.trackBarControl1.Value = 50;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarControl1.EditValue = 50;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 90);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(284, 18);
            this.progressBarControl1.TabIndex = 1;
            // 
            // myTrackBar1
            // 
            this.myTrackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myTrackBar1.EditValue = null;
            this.myTrackBar1.Location = new System.Drawing.Point(0, 45);
            this.myTrackBar1.Name = "myTrackBar1";
            this.myTrackBar1.Properties.Progress = null;
            this.myTrackBar1.Size = new System.Drawing.Size(284, 45);
            this.myTrackBar1.TabIndex = 2;
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(13, 115);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(119, 23);
            this.checkButton1.TabIndex = 3;
            this.checkButton1.Text = "Use ProgressBar";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.myTrackBar1);
            this.Controls.Add(this.trackBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private WindowsFormsApplication1.MyTrackBar myTrackBar1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}

