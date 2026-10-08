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
    public partial class AddExpenseUc : UserControl
    {
        public AddExpenseUc()
        {
            InitializeComponent();
            currencyLbl.Text = DataManager.CurrencySymbol;
        }

        private bool checkBudget()
        {
            int tot = 0;
            foreach (var item in DataManager.expenselist)
            {
                if (item.Category == catComboBox.SelectedItem.ToString() && item.Date.Month == dateTimePicker1.Value.Month)
                {
                    tot += item.Amount;
                }
            }
            var str = DataManager.ExpensecategoryDict.FirstOrDefault(ele => string.Equals(ele.Key, catComboBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase));
            if (str.Value.budget >= tot + int.Parse(AmtTxt.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void catTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            catComboBox.DataSource = null;
            catComboBox.Items.Clear();

            if (catTypeCombo.SelectedItem.ToString() == "INCOME")
            {
                catComboBox.DataSource = DataManager.IncomecategoryDict.Keys.ToList();
                addaExpIncBtn.Text = "ADD INCOME";
            }
            if (catTypeCombo.SelectedItem.ToString() == "EXPENSE")
            {
                catComboBox.DataSource = DataManager.ExpensecategoryDict.Keys.ToList();
                addaExpIncBtn.Text = "ADD EXPENSE";
            }
        }

        private void AmtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || (AmtTxt.Text.Length >= 6)) e.Handled = true;
        }

        private void addaExpIncBtn_Click(object sender, EventArgs e)
        {
            if (catTypeCombo.SelectedItem.ToString() == "INCOME")
            {
                string cat = catComboBox.SelectedItem.ToString();
                DataManager.incomelist.Add(new Income { Category = cat, CategoryName = nameTxt.Text, Amount = int.Parse(AmtTxt.Text), Date = dateTimePicker1.Value });
            }
            if (catTypeCombo.SelectedItem.ToString() == "EXPENSE")
            {
                if (checkBudget())
                {
                    string cat = catComboBox.SelectedItem.ToString();
                    DataManager.expenselist.Add(new Expense { Category = cat, CategoryName = nameTxt.Text, Amount = int.Parse(AmtTxt.Text), Date = dateTimePicker1.Value });
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                           "Budget Limit Exceeded...Do you want to proceed?",
                           "Confirmation",
                           MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question
                    );
                    if (result == DialogResult.OK)
                    {
                        string cat = catComboBox.SelectedItem.ToString();
                        DataManager.expenselist.Add(new Expense { Category = cat, CategoryName = nameTxt.Text, Amount = int.Parse(AmtTxt.Text), Date = dateTimePicker1.Value });
                        MessageBox.Show("Added expense");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Not added");
                    }
                }
                foreach (Control ctrl in addExpPnl.Controls)
                {
                    if (ctrl is TextBox tb)
                    {
                        tb.Text = "";
                    }
                }
            }
        }

    }
}
