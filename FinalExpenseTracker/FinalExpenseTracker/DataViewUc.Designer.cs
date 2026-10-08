namespace FinalExpenseTracker
{
    partial class DataViewUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewUc));
            this.dataViewPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.filterUc1 = new FinalExpenseTracker.FilterUc();
            this.dataViewPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewPnl
            // 
            this.dataViewPnl.Controls.Add(this.pictureBox1);
            this.dataViewPnl.Controls.Add(this.DataGrid);
            this.dataViewPnl.Controls.Add(this.filterUc1);
            this.dataViewPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewPnl.Location = new System.Drawing.Point(0, 0);
            this.dataViewPnl.Name = "dataViewPnl";
            this.dataViewPnl.Size = new System.Drawing.Size(1082, 664);
            this.dataViewPnl.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(27, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 49);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 106);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1082, 558);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGrid_RowPrePaint);
            // 
            // filterUc1
            // 
            this.filterUc1.BackColor = System.Drawing.Color.LightBlue;
            this.filterUc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterUc1.Location = new System.Drawing.Point(0, 0);
            this.filterUc1.Name = "filterUc1";
            this.filterUc1.Size = new System.Drawing.Size(1082, 106);
            this.filterUc1.TabIndex = 1;
            // 
            // DataViewUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataViewPnl);
            this.Name = "DataViewUc";
            this.Size = new System.Drawing.Size(1082, 664);
            this.Load += new System.EventHandler(this.DataViewUc_Load);
            this.dataViewPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataViewPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGrid;
        private FilterUc filterUc1;
    }
}
