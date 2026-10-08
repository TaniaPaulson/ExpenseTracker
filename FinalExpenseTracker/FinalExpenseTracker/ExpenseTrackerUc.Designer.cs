namespace FinalExpenseTracker
{
    partial class ExpenseTrackerUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseTrackerUc));
            this.DisplayPnl = new System.Windows.Forms.Panel();
            this.remCatPnl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.piePnl = new System.Windows.Forms.Panel();
            this.pIeChartUc1 = new FinalExpenseTracker.PIeChartUc();
            this.filterUc2 = new FinalExpenseTracker.FilterUc();
            this.currSymLbl = new System.Windows.Forms.Label();
            this.catTypeLbl = new System.Windows.Forms.Label();
            this.symbolComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.addCatBtn = new System.Windows.Forms.Button();
            this.addExpBtn = new System.Windows.Forms.Button();
            this.gridViewBtn = new System.Windows.Forms.Button();
            this.pieBtn = new System.Windows.Forms.Button();
            this.remCatBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MenuPnl = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DisplayPnl.SuspendLayout();
            this.remCatPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.piePnl.SuspendLayout();
            this.MenuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPnl
            // 
            this.DisplayPnl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisplayPnl.BackgroundImage")));
            this.DisplayPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DisplayPnl.Controls.Add(this.remCatPnl);
            this.DisplayPnl.Controls.Add(this.piePnl);
            this.DisplayPnl.Controls.Add(this.currSymLbl);
            this.DisplayPnl.Controls.Add(this.catTypeLbl);
            this.DisplayPnl.Controls.Add(this.symbolComboBox);
            this.DisplayPnl.Controls.Add(this.TypeComboBox);
            this.DisplayPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPnl.Location = new System.Drawing.Point(299, 0);
            this.DisplayPnl.Name = "DisplayPnl";
            this.DisplayPnl.Size = new System.Drawing.Size(1046, 821);
            this.DisplayPnl.TabIndex = 3;
            // 
            // remCatPnl
            // 
            this.remCatPnl.BackColor = System.Drawing.Color.AliceBlue;
            this.remCatPnl.Controls.Add(this.pictureBox2);
            this.remCatPnl.Controls.Add(this.listBox2);
            this.remCatPnl.Controls.Add(this.listBox1);
            this.remCatPnl.Controls.Add(this.label12);
            this.remCatPnl.Controls.Add(this.label11);
            this.remCatPnl.Location = new System.Drawing.Point(79, 58);
            this.remCatPnl.Name = "remCatPnl";
            this.remCatPnl.Size = new System.Drawing.Size(781, 547);
            this.remCatPnl.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(663, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(49, 327);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(653, 130);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(49, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(653, 130);
            this.listBox1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "EXPENSE";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "INCOME";
            // 
            // piePnl
            // 
            this.piePnl.Controls.Add(this.pIeChartUc1);
            this.piePnl.Controls.Add(this.filterUc2);
            this.piePnl.Location = new System.Drawing.Point(34, 111);
            this.piePnl.Name = "piePnl";
            this.piePnl.Size = new System.Drawing.Size(978, 654);
            this.piePnl.TabIndex = 13;
            // 
            // pIeChartUc1
            // 
            this.pIeChartUc1.BackColor = System.Drawing.Color.AliceBlue;
            this.pIeChartUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pIeChartUc1.Location = new System.Drawing.Point(0, 112);
            this.pIeChartUc1.Name = "pIeChartUc1";
            this.pIeChartUc1.Size = new System.Drawing.Size(978, 542);
            this.pIeChartUc1.TabIndex = 1;
            this.pIeChartUc1.Load += new System.EventHandler(this.pIeChartUc1_Load);
            // 
            // filterUc2
            // 
            this.filterUc2.BackColor = System.Drawing.Color.LightBlue;
            this.filterUc2.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterUc2.Location = new System.Drawing.Point(0, 0);
            this.filterUc2.Name = "filterUc2";
            this.filterUc2.Size = new System.Drawing.Size(978, 112);
            this.filterUc2.TabIndex = 0;
            // 
            // currSymLbl
            // 
            this.currSymLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currSymLbl.AutoSize = true;
            this.currSymLbl.BackColor = System.Drawing.Color.Transparent;
            this.currSymLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currSymLbl.Location = new System.Drawing.Point(640, 777);
            this.currSymLbl.Name = "currSymLbl";
            this.currSymLbl.Size = new System.Drawing.Size(191, 20);
            this.currSymLbl.TabIndex = 12;
            this.currSymLbl.Text = "CURRENCY SYMBOL:";
            // 
            // catTypeLbl
            // 
            this.catTypeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catTypeLbl.AutoSize = true;
            this.catTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.catTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTypeLbl.Location = new System.Drawing.Point(669, 32);
            this.catTypeLbl.Name = "catTypeLbl";
            this.catTypeLbl.Size = new System.Drawing.Size(162, 20);
            this.catTypeLbl.TabIndex = 11;
            this.catTypeLbl.Text = "CATEGORY TYPE:";
            // 
            // symbolComboBox
            // 
            this.symbolComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.symbolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolComboBox.FormattingEnabled = true;
            this.symbolComboBox.Items.AddRange(new object[] {
            "$",
            "@",
            "&",
            "#"});
            this.symbolComboBox.Location = new System.Drawing.Point(837, 771);
            this.symbolComboBox.Name = "symbolComboBox";
            this.symbolComboBox.Size = new System.Drawing.Size(145, 26);
            this.symbolComboBox.TabIndex = 4;
            this.symbolComboBox.SelectedIndexChanged += new System.EventHandler(this.symbolComboBox_SelectedIndexChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeComboBox.BackColor = System.Drawing.Color.White;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "INCOME",
            "EXPENSE"});
            this.TypeComboBox.Location = new System.Drawing.Point(837, 26);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(145, 26);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // addCatBtn
            // 
            this.addCatBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCatBtn.BackColor = System.Drawing.Color.Azure;
            this.addCatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCatBtn.BackgroundImage")));
            this.addCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatBtn.Location = new System.Drawing.Point(85, 32);
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.Size = new System.Drawing.Size(110, 89);
            this.addCatBtn.TabIndex = 0;
            this.addCatBtn.UseVisualStyleBackColor = false;
            this.addCatBtn.Click += new System.EventHandler(this.addCatBtn_Click);
            // 
            // addExpBtn
            // 
            this.addExpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addExpBtn.BackColor = System.Drawing.Color.Azure;
            this.addExpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addExpBtn.BackgroundImage")));
            this.addExpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpBtn.Location = new System.Drawing.Point(85, 178);
            this.addExpBtn.Name = "addExpBtn";
            this.addExpBtn.Size = new System.Drawing.Size(110, 89);
            this.addExpBtn.TabIndex = 1;
            this.addExpBtn.UseVisualStyleBackColor = false;
            this.addExpBtn.Click += new System.EventHandler(this.addExpBtn_Click);
            // 
            // gridViewBtn
            // 
            this.gridViewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridViewBtn.BackColor = System.Drawing.Color.Azure;
            this.gridViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridViewBtn.BackgroundImage")));
            this.gridViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBtn.Location = new System.Drawing.Point(85, 320);
            this.gridViewBtn.Name = "gridViewBtn";
            this.gridViewBtn.Size = new System.Drawing.Size(110, 89);
            this.gridViewBtn.TabIndex = 2;
            this.gridViewBtn.UseVisualStyleBackColor = false;
            this.gridViewBtn.Click += new System.EventHandler(this.gridViewBtn_Click);
            // 
            // pieBtn
            // 
            this.pieBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieBtn.BackColor = System.Drawing.Color.Azure;
            this.pieBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieBtn.BackgroundImage")));
            this.pieBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieBtn.Location = new System.Drawing.Point(85, 472);
            this.pieBtn.Name = "pieBtn";
            this.pieBtn.Size = new System.Drawing.Size(110, 89);
            this.pieBtn.TabIndex = 3;
            this.pieBtn.UseVisualStyleBackColor = false;
            this.pieBtn.Click += new System.EventHandler(this.pieBtn_Click);
            // 
            // remCatBtn
            // 
            this.remCatBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remCatBtn.BackColor = System.Drawing.Color.Azure;
            this.remCatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remCatBtn.BackgroundImage")));
            this.remCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remCatBtn.Location = new System.Drawing.Point(85, 625);
            this.remCatBtn.Name = "remCatBtn";
            this.remCatBtn.Size = new System.Drawing.Size(110, 89);
            this.remCatBtn.TabIndex = 4;
            this.remCatBtn.UseVisualStyleBackColor = false;
            this.remCatBtn.Click += new System.EventHandler(this.remCatBtn_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "ADD CATEGORY";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "ADD INCOME/EXPENSE";
            // 
            // MenuPnl
            // 
            this.MenuPnl.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuPnl.Controls.Add(this.label17);
            this.MenuPnl.Controls.Add(this.label16);
            this.MenuPnl.Controls.Add(this.label15);
            this.MenuPnl.Controls.Add(this.label14);
            this.MenuPnl.Controls.Add(this.label13);
            this.MenuPnl.Controls.Add(this.remCatBtn);
            this.MenuPnl.Controls.Add(this.pieBtn);
            this.MenuPnl.Controls.Add(this.gridViewBtn);
            this.MenuPnl.Controls.Add(this.addExpBtn);
            this.MenuPnl.Controls.Add(this.addCatBtn);
            this.MenuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPnl.Location = new System.Drawing.Point(0, 0);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.Size = new System.Drawing.Size(299, 821);
            this.MenuPnl.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 726);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "REMOVE CATEGORY";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 575);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "PIE CHART";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "GRID VIEW";
            // 
            // ExpenseTrackerUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayPnl);
            this.Controls.Add(this.MenuPnl);
            this.Name = "ExpenseTrackerUc";
            this.Size = new System.Drawing.Size(1345, 821);
            this.Load += new System.EventHandler(this.ExpenseTrackerUc_Load);
            this.Resize += new System.EventHandler(this.ExpenseTrackerUc_Resize);
            this.DisplayPnl.ResumeLayout(false);
            this.DisplayPnl.PerformLayout();
            this.remCatPnl.ResumeLayout(false);
            this.remCatPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.piePnl.ResumeLayout(false);
            this.MenuPnl.ResumeLayout(false);
            this.MenuPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPnl;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox symbolComboBox;
        private System.Windows.Forms.Label currSymLbl;
        private System.Windows.Forms.Label catTypeLbl;
        private System.Windows.Forms.Panel piePnl;
        private FilterUc filterUc2;
        private PIeChartUc pIeChartUc1;
        private System.Windows.Forms.Panel remCatPnl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addCatBtn;
        private System.Windows.Forms.Button addExpBtn;
        private System.Windows.Forms.Button gridViewBtn;
        private System.Windows.Forms.Button pieBtn;
        private System.Windows.Forms.Button remCatBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel MenuPnl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}
