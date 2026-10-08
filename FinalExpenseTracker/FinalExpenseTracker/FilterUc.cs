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
    public partial class FilterUc : UserControl
    {
        public FilterUc()
        {
            InitializeComponent();
            data.Columns.Add("Category");
            data.Columns.Add("Name");
            data.Columns.Add("Amount");
            data.Columns.Add("Date");

            monthlyPnl.Visible = false;
            dailyPnl.Visible = false;
        }

        string category;

        public event EventHandler<DataTable> PassData;

        public event EventHandler<List<Expense>> PassList;

        public event EventHandler<List<Income>> PassIncome;

        DataTable data = new DataTable();

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category == "EXPENSE")
            {
                if (FilterComboBox.SelectedItem.ToString() == "TODAY")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = false;
                    List<Expense> temp = new List<Expense>();
                    data.Rows.Clear();
                    foreach (var exp in DataManager.expenselist)
                    {
                        if (exp.Date.Date == DateTime.Now.Date)
                        {
                            data.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                            temp.Add(exp);
                        }
                    }
                    PassData?.Invoke(this, data);
                    PassList?.Invoke(this, temp);
                }
                if (FilterComboBox.SelectedItem.ToString() == "THIS MONTH")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = false;
                    List<Expense> temp = new List<Expense>();
                    data.Rows.Clear();
                    foreach (var exp in DataManager.expenselist)
                    {
                        if (exp.Date.Month == DateTime.Now.Month)
                        {
                            data.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                            temp.Add(exp);
                        }
                    }
                    PassData?.Invoke(this, data);
                    PassList?.Invoke(this, temp);
                }
                if (FilterComboBox.SelectedItem.ToString() == "MONTHLY")
                {
                    dailyPnl.Visible = false;
                    monthlyPnl.Visible = true;
                }
                if (FilterComboBox.SelectedItem.ToString() == "DAILY")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = true;
                }
            }
            if (category == "INCOME")
            {
                if (FilterComboBox.SelectedItem.ToString() == "TODAY")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = false;
                    List<Income> temp = new List<Income>();
                    data.Rows.Clear();
                    foreach (var inc in DataManager.incomelist)
                    {
                        if (inc.Date.Date == DateTime.Now.Date)
                        {
                            data.Rows.Add(inc.Category, inc.CategoryName, DataManager.CurrencySymbol + " " + inc.Amount, inc.Date.ToString("dd/MM/yyyy"));
                            temp.Add(inc);
                        }
                    }
                    PassData?.Invoke(this, data);
                    PassIncome?.Invoke(this, temp);
                }
                if (FilterComboBox.SelectedItem.ToString() == "THIS MONTH")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = false;
                    List<Income> temp = new List<Income>();
                    data.Rows.Clear();
                    foreach (var inc in DataManager.incomelist)
                    {
                        if (inc.Date.Month == DateTime.Now.Month)
                        {
                            data.Rows.Add(inc.Category, inc.CategoryName, DataManager.CurrencySymbol + " " + inc.Amount, inc.Date.ToString("dd/MM/yyyy"));
                            temp.Add(inc);
                        }
                    }
                    PassData?.Invoke(this, data);
                    PassIncome?.Invoke(this, temp);
                }
                if (FilterComboBox.SelectedItem.ToString() == "MONTHLY")
                {
                    dailyPnl.Visible = false;
                    monthlyPnl.Visible = true;
                }
                if (FilterComboBox.SelectedItem.ToString() == "DAILY")
                {
                    monthlyPnl.Visible = false;
                    dailyPnl.Visible = true;
                }
            }
        }

        internal void PassCategory(string v)
        {
            category = v;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category == "EXPENSE")
            {
                List<Expense> temp = new List<Expense>();
                data.Rows.Clear();
                foreach (var exp in DataManager.expenselist)
                {
                    if (exp.Date.Month == monthComboBox.SelectedIndex+1)
                    {
                        data.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                        temp.Add(exp);
                    }
                }
                PassData?.Invoke(this, data);
                PassList?.Invoke(this, temp);
            }
            if (category == "INCOME")
            {
                List<Income> temp = new List<Income>();
                data.Rows.Clear();
                foreach (var inc in DataManager.incomelist)
                {
                    if (inc.Date.Month == monthComboBox.SelectedIndex + 1)
                    {
                        data.Rows.Add(inc.Category, inc.CategoryName, DataManager.CurrencySymbol + " " + inc.Amount, inc.Date.ToString("dd/MM/yyyy"));
                        temp.Add(inc);
                    }
                }
                PassData?.Invoke(this, data);
                PassIncome?.Invoke(this, temp);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (category == "EXPENSE")
            {
                List<Expense> temp = new List<Expense>();
                data.Rows.Clear();
                foreach (var exp in DataManager.expenselist)
                {
                    if (exp.Date.Date == dateTimePicker1.Value.Date)
                    {
                        data.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                        temp.Add(exp);
                    }
                }
                PassData?.Invoke(this, data);
                PassList?.Invoke(this, temp);
            }
            if (category == "Income")
            {
                List<Income> temp = new List<Income>();
                data.Rows.Clear();
                foreach (var inc in DataManager.incomelist)
                {
                    if (inc.Date.Date == dateTimePicker1.Value.Date)
                    {
                        data.Rows.Add(inc.Category, inc.CategoryName, DataManager.CurrencySymbol + " " + inc.Amount, inc.Date.ToString("dd/MM/yyyy"));
                        temp.Add(inc);
                    }
                }
                PassData?.Invoke(this, data);
                PassIncome?.Invoke(this, temp);
            }
        }
    }
}
