using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExpenseTracker
{
    public partial class AddCategoryUc : UserControl
    {
        public AddCategoryUc()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
           colorLbl.BackColor = colorDialog1.Color;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (catTypeComboBox.SelectedItem.ToString() == "INCOME")
            {
                DataManager.IncomecategoryDict.Add(catNameTxt.Text, colorDialog1.Color);
            }
            if (catTypeComboBox.SelectedItem.ToString() == "EXPENSE")
            {
                DataManager.ExpensecategoryDict.Add(catNameTxt.Text, (colorDialog1.Color, int.Parse(budgetTxt.Text)));
            }
            catNameTxt.Text = "";
            budgetTxt.Text = "";
            colorLbl.BackColor = Color.Transparent;
            this.Hide();
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void budgetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || (budgetTxt.Text.Length >= 6)) e.Handled = true;
        }
    }
}
