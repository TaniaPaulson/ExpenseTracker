namespace FinalExpenseTracker
{
    partial class FilterUc
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
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.monthlyPnl = new System.Windows.Forms.Panel();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyPnl = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.monthlyPnl.SuspendLayout();
            this.dailyPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "TODAY",
            "THIS MONTH",
            "MONTHLY",
            "DAILY"});
            this.FilterComboBox.Location = new System.Drawing.Point(682, 43);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(260, 26);
            this.FilterComboBox.TabIndex = 11;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "FILTER:";
            // 
            // monthlyPnl
            // 
            this.monthlyPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthlyPnl.Controls.Add(this.monthComboBox);
            this.monthlyPnl.Controls.Add(this.label1);
            this.monthlyPnl.Location = new System.Drawing.Point(26, 24);
            this.monthlyPnl.Name = "monthlyPnl";
            this.monthlyPnl.Size = new System.Drawing.Size(383, 52);
            this.monthlyPnl.TabIndex = 12;
            // 
            // monthComboBox
            // 
            this.monthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER "});
            this.monthComboBox.Location = new System.Drawing.Point(105, 14);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(260, 26);
            this.monthComboBox.TabIndex = 13;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "MONTH:";
            // 
            // dailyPnl
            // 
            this.dailyPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dailyPnl.Controls.Add(this.dateTimePicker1);
            this.dailyPnl.Controls.Add(this.label2);
            this.dailyPnl.Location = new System.Drawing.Point(23, 27);
            this.dailyPnl.Name = "dailyPnl";
            this.dailyPnl.Size = new System.Drawing.Size(383, 52);
            this.dailyPnl.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "DATE:";
            // 
            // FilterUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.dailyPnl);
            this.Controls.Add(this.monthlyPnl);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label8);
            this.Name = "FilterUc";
            this.Size = new System.Drawing.Size(977, 107);
            this.monthlyPnl.ResumeLayout(false);
            this.monthlyPnl.PerformLayout();
            this.dailyPnl.ResumeLayout(false);
            this.dailyPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel monthlyPnl;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dailyPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
