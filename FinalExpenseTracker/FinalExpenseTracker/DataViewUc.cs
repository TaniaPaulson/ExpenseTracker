using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FinalExpenseTracker
{
    public partial class DataViewUc : UserControl
    {
        string CatName;

        public DataViewUc()
        {
            InitializeComponent();
            filterUc1.PassData += FilterUc1_PassData;
        }

        private void FilterUc1_PassData(object sender, DataTable e)
        {
            DataGrid.DataSource = e;
        }

        DataTable dt = new DataTable();

        private void DataViewUc_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Category");
            dt.Columns.Add("Name");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");

            DataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DataGrid.DefaultCellStyle.Font = new Font("Arial", 12);
            DataGrid.DataSource = dt;

            displayDetails();
        }


        public void displayDetails()
        {
            if (CatName == "INCOME")
            {
                dt.Rows.Clear();
                foreach (var exp in DataManager.incomelist)
                {
                    dt.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                }
            }
            if ( CatName== "EXPENSE")
            {
                dt.Rows.Clear();
                foreach (var exp in DataManager.expenselist)
                {
                    dt.Rows.Add(exp.Category, exp.CategoryName, DataManager.CurrencySymbol + " " + exp.Amount, exp.Date.ToString("dd/MM/yyyy"));
                }
            }
        }

        internal void Category(string v)
        {
            CatName = v;
            filterUc1.PassCategory(v);
            displayDetails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count > 0)
            {
                var item = DataGrid.SelectedRows[0];
                string categoryName = item.Cells["Name"].Value.ToString();
                string amt = item.Cells["Amount"].Value.ToString();
                string cleanedInput = Regex.Replace(amt, @"\W", "");
                int amount = int.Parse(cleanedInput);
                var remove = DataManager.expenselist.FirstOrDefault(ele => ele.Amount == amount && ele.CategoryName == categoryName);
                if (remove != null)
                {
                    DataManager.expenselist.Remove(remove);
                }
                else
                {
                    var rem = DataManager.incomelist.FirstOrDefault(ele => ele.Amount == amount && ele.CategoryName == categoryName);
                    DataManager.incomelist.Remove(rem);
                }
            }
            displayDetails();
        }

        private void DataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (DataGrid.Rows[e.RowIndex].Selected)
            {
                e.Graphics.FillRectangle(Brushes.White, e.RowBounds);
                DataGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                DataGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.White;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.AliceBlue, e.RowBounds);
                DataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }

            e.PaintCellsContent(e.ClipBounds);
            e.Handled = true;
        }

    }
}
