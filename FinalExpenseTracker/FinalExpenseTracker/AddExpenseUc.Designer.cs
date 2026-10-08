namespace FinalExpenseTracker
{
    partial class AddExpenseUc
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
            this.addExpPnl = new System.Windows.Forms.Panel();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AmtTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.catTypeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addaExpIncBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addExpPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addExpPnl
            // 
            this.addExpPnl.BackColor = System.Drawing.Color.AliceBlue;
            this.addExpPnl.Controls.Add(this.currencyLbl);
            this.addExpPnl.Controls.Add(this.dateTimePicker1);
            this.addExpPnl.Controls.Add(this.label5);
            this.addExpPnl.Controls.Add(this.AmtTxt);
            this.addExpPnl.Controls.Add(this.label4);
            this.addExpPnl.Controls.Add(this.catTypeCombo);
            this.addExpPnl.Controls.Add(this.label8);
            this.addExpPnl.Controls.Add(this.addaExpIncBtn);
            this.addExpPnl.Controls.Add(this.nameTxt);
            this.addExpPnl.Controls.Add(this.label6);
            this.addExpPnl.Controls.Add(this.catComboBox);
            this.addExpPnl.Controls.Add(this.label7);
            this.addExpPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpPnl.Location = new System.Drawing.Point(0, 0);
            this.addExpPnl.Name = "addExpPnl";
            this.addExpPnl.Size = new System.Drawing.Size(918, 605);
            this.addExpPnl.TabIndex = 3;
            // 
            // currencyLbl
            // 
            this.currencyLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currencyLbl.Location = new System.Drawing.Point(400, 288);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(33, 24);
            this.currencyLbl.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "DATE:";
            // 
            // AmtTxt
            // 
            this.AmtTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtTxt.Location = new System.Drawing.Point(429, 288);
            this.AmtTxt.Name = "AmtTxt";
            this.AmtTxt.Size = new System.Drawing.Size(231, 24);
            this.AmtTxt.TabIndex = 11;
            this.AmtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmtTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "AMOUNT:";
            // 
            // catTypeCombo
            // 
            this.catTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTypeCombo.FormattingEnabled = true;
            this.catTypeCombo.Items.AddRange(new object[] {
            "INCOME",
            "EXPENSE"});
            this.catTypeCombo.Location = new System.Drawing.Point(400, 97);
            this.catTypeCombo.Name = "catTypeCombo";
            this.catTypeCombo.Size = new System.Drawing.Size(260, 26);
            this.catTypeCombo.TabIndex = 9;
            this.catTypeCombo.SelectedIndexChanged += new System.EventHandler(this.catTypeCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "CATEGORY TYPE:\r\n";
            // 
            // addaExpIncBtn
            // 
            this.addaExpIncBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addaExpIncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addaExpIncBtn.Location = new System.Drawing.Point(310, 444);
            this.addaExpIncBtn.Name = "addaExpIncBtn";
            this.addaExpIncBtn.Size = new System.Drawing.Size(243, 38);
            this.addaExpIncBtn.TabIndex = 7;
            this.addaExpIncBtn.Text = "ADD ";
            this.addaExpIncBtn.UseVisualStyleBackColor = true;
            this.addaExpIncBtn.Click += new System.EventHandler(this.addaExpIncBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(400, 221);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(260, 24);
            this.nameTxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "NAME:";
            // 
            // catComboBox
            // 
            this.catComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(400, 155);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(260, 26);
            this.catComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "CATEGORY:";
            // 
            // AddExpenseUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addExpPnl);
            this.Name = "AddExpenseUc";
            this.Size = new System.Drawing.Size(918, 605);
            this.addExpPnl.ResumeLayout(false);
            this.addExpPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addExpPnl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmtTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox catTypeCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addaExpIncBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox catComboBox;
        private System.Windows.Forms.Label label7;
    }
}
