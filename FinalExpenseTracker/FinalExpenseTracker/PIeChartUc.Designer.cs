namespace FinalExpenseTracker
{
    partial class PIeChartUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorGuidePnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // colorGuidePnl
            // 
            this.colorGuidePnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorGuidePnl.Location = new System.Drawing.Point(774, 17);
            this.colorGuidePnl.Name = "colorGuidePnl";
            this.colorGuidePnl.Size = new System.Drawing.Size(242, 168);
            this.colorGuidePnl.TabIndex = 0;
            // 
            // PIeChartUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.colorGuidePnl);
            this.DoubleBuffered = true;
            this.Name = "PIeChartUc";
            this.Size = new System.Drawing.Size(1032, 654);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PIeChartUc_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel colorGuidePnl;
    }
}
