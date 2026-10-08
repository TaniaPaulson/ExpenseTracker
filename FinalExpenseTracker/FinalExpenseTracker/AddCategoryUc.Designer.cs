namespace FinalExpenseTracker
{
    partial class AddCategoryUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryUc));
            this.addCatPnl = new System.Windows.Forms.Panel();
            this.budgetTxt = new System.Windows.Forms.TextBox();
            this.budgetLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.colorLbl = new System.Windows.Forms.Label();
            this.colorBtn = new System.Windows.Forms.Button();
            this.selColLbl = new System.Windows.Forms.Label();
            this.catNameTxt = new System.Windows.Forms.TextBox();
            this.catNameLbl = new System.Windows.Forms.Label();
            this.catTypeComboBox = new System.Windows.Forms.ComboBox();
            this.catLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.closeLbl = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.addCatPnl.SuspendLayout();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCatPnl
            // 
            this.addCatPnl.BackColor = System.Drawing.Color.AliceBlue;
            this.addCatPnl.Controls.Add(this.topPnl);
            this.addCatPnl.Controls.Add(this.budgetTxt);
            this.addCatPnl.Controls.Add(this.budgetLbl);
            this.addCatPnl.Controls.Add(this.addBtn);
            this.addCatPnl.Controls.Add(this.colorLbl);
            this.addCatPnl.Controls.Add(this.colorBtn);
            this.addCatPnl.Controls.Add(this.selColLbl);
            this.addCatPnl.Controls.Add(this.catNameTxt);
            this.addCatPnl.Controls.Add(this.catNameLbl);
            this.addCatPnl.Controls.Add(this.catTypeComboBox);
            this.addCatPnl.Controls.Add(this.catLbl);
            this.addCatPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCatPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatPnl.Location = new System.Drawing.Point(0, 0);
            this.addCatPnl.Name = "addCatPnl";
            this.addCatPnl.Size = new System.Drawing.Size(884, 585);
            this.addCatPnl.TabIndex = 2;
            // 
            // budgetTxt
            // 
            this.budgetTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.budgetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTxt.Location = new System.Drawing.Point(370, 258);
            this.budgetTxt.Name = "budgetTxt";
            this.budgetTxt.Size = new System.Drawing.Size(260, 24);
            this.budgetTxt.TabIndex = 9;
            // 
            // budgetLbl
            // 
            this.budgetLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.budgetLbl.AutoSize = true;
            this.budgetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLbl.Location = new System.Drawing.Point(259, 262);
            this.budgetLbl.Name = "budgetLbl";
            this.budgetLbl.Size = new System.Drawing.Size(81, 20);
            this.budgetLbl.TabIndex = 8;
            this.budgetLbl.Text = "BUDGET:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(304, 410);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(243, 38);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "ADD ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // colorLbl
            // 
            this.colorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorLbl.BackColor = System.Drawing.Color.Transparent;
            this.colorLbl.Location = new System.Drawing.Point(602, 337);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(35, 28);
            this.colorLbl.TabIndex = 6;
            // 
            // colorBtn
            // 
            this.colorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorBtn.Location = new System.Drawing.Point(370, 337);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(205, 32);
            this.colorBtn.TabIndex = 5;
            this.colorBtn.Text = "COLOR";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // selColLbl
            // 
            this.selColLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selColLbl.AutoSize = true;
            this.selColLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selColLbl.Location = new System.Drawing.Point(205, 343);
            this.selColLbl.Name = "selColLbl";
            this.selColLbl.Size = new System.Drawing.Size(135, 20);
            this.selColLbl.TabIndex = 4;
            this.selColLbl.Text = "SELECT COLOR:";
            // 
            // catNameTxt
            // 
            this.catNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameTxt.Location = new System.Drawing.Point(370, 178);
            this.catNameTxt.Name = "catNameTxt";
            this.catNameTxt.Size = new System.Drawing.Size(260, 24);
            this.catNameTxt.TabIndex = 3;
            // 
            // catNameLbl
            // 
            this.catNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catNameLbl.AutoSize = true;
            this.catNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameLbl.Location = new System.Drawing.Point(187, 182);
            this.catNameLbl.Name = "catNameLbl";
            this.catNameLbl.Size = new System.Drawing.Size(153, 20);
            this.catNameLbl.TabIndex = 2;
            this.catNameLbl.Text = "CATEGORY NAME:";
            // 
            // catTypeComboBox
            // 
            this.catTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTypeComboBox.FormattingEnabled = true;
            this.catTypeComboBox.Items.AddRange(new object[] {
            "INCOME",
            "EXPENSE"});
            this.catTypeComboBox.Location = new System.Drawing.Point(370, 96);
            this.catTypeComboBox.Name = "catTypeComboBox";
            this.catTypeComboBox.Size = new System.Drawing.Size(260, 26);
            this.catTypeComboBox.TabIndex = 1;
            // 
            // catLbl
            // 
            this.catLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catLbl.AutoSize = true;
            this.catLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLbl.Location = new System.Drawing.Point(187, 98);
            this.catLbl.Name = "catLbl";
            this.catLbl.Size = new System.Drawing.Size(148, 20);
            this.catLbl.TabIndex = 0;
            this.catLbl.Text = "CATEGORY TYPE:\r\n";
            // 
            // closeLbl
            // 
            this.closeLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeLbl.Image = ((System.Drawing.Image)(resources.GetObject("closeLbl.Image")));
            this.closeLbl.Location = new System.Drawing.Point(855, 0);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(29, 29);
            this.closeLbl.TabIndex = 10;
            this.closeLbl.Click += new System.EventHandler(this.closeLbl_Click);
            // 
            // topPnl
            // 
            this.topPnl.Controls.Add(this.closeLbl);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(884, 29);
            this.topPnl.TabIndex = 11;
            // 
            // AddCategoryUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCatPnl);
            this.Name = "AddCategoryUc";
            this.Size = new System.Drawing.Size(884, 585);
            this.addCatPnl.ResumeLayout(false);
            this.addCatPnl.PerformLayout();
            this.topPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addCatPnl;
        private System.Windows.Forms.TextBox budgetTxt;
        private System.Windows.Forms.Label budgetLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Label selColLbl;
        private System.Windows.Forms.TextBox catNameTxt;
        private System.Windows.Forms.Label catNameLbl;
        private System.Windows.Forms.ComboBox catTypeComboBox;
        private System.Windows.Forms.Label catLbl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.Panel topPnl;
    }
}
