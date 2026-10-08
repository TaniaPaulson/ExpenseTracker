namespace FinalExpenseTracker
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
            this.expenseTrackerUc1 = new FinalExpenseTracker.ExpenseTrackerUc();
            this.SuspendLayout();
            // 
            // expenseTrackerUc1
            // 
            this.expenseTrackerUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseTrackerUc1.Location = new System.Drawing.Point(0, 0);
            this.expenseTrackerUc1.Name = "expenseTrackerUc1";
            this.expenseTrackerUc1.Size = new System.Drawing.Size(1192, 813);
            this.expenseTrackerUc1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 813);
            this.Controls.Add(this.expenseTrackerUc1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1208, 852);
            this.Name = "Form1";
            this.Text = "EXPENSE TRACKER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private ExpenseTrackerUc expenseTrackerUc1;
    }
}

