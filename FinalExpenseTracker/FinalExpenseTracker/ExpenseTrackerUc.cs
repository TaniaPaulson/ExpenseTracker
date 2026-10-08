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
    public partial class ExpenseTrackerUc : UserControl
    {
        AddCategoryUc addcat;
        AddExpenseUc addexp;
        DataViewUc datauc;

        public ExpenseTrackerUc()
        {
            InitializeComponent();
            Controlvisibility();
            TypeComboBox.Enabled = false;
            filterUc2.PassList += FilterUc2_PassList;
            filterUc2.PassIncome += FilterUc2_PassIncome;
        }        

        private void Controlvisibility()
        {
            //addCatPnl.Visible = false;
            //addExpPnl.Visible = false;
            //dataViewPnl.Visible = false;
            piePnl.Visible = false;
            remCatPnl.Visible = false;
        }

        private void ExpenseTrackerUc_Resize(object sender, EventArgs e)
        {
            MenuPnl.Size = new Size((int)((20.0 / 100.0) * this.Width), (int)((100.0 / 100.0) * this.Height));

            int x = (int)((10.0 / 100.0) * DisplayPnl.Width);
            int y = (int)((10.0 / 100.0) * DisplayPnl.Height);

            if (addcat != null)
            {
                addcat.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
                addcat.Location = new Point(x, y);
            }

            if (addexp != null)
            {
                addcat.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
                addcat.Location = new Point(x, y);
            }

            if (datauc != null)
            {
                datauc.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
                datauc.Location = new Point(x, y);
            }

            piePnl.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
            piePnl.Location = new Point(x, y);

            remCatPnl.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
            remCatPnl.Location = new Point(x, y);


        }

        private void addCatBtn_Click(object sender, EventArgs e)
        {
            TypeComboBox.Enabled = false;
            Controlvisibility();
            addcat = new AddCategoryUc();
            int x = (int)((10.0 / 100.0) * DisplayPnl.Width);
            int y = (int)((10.0 / 100.0) * DisplayPnl.Height);
            addcat.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
            addcat.Location = new Point(x, y);
            clearControls();
            DisplayPnl.Controls.Add(addcat);
        }

        private void addExpBtn_Click(object sender, EventArgs e)
        {
            Controlvisibility();
            TypeComboBox.Enabled = false;
            addexp = new AddExpenseUc();
            int x = (int)((10.0 / 100.0) * DisplayPnl.Width);
            int y = (int)((10.0 / 100.0) * DisplayPnl.Height);
            addexp.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
            addexp.Location = new Point(x, y);
            clearControls();
            DisplayPnl.Controls.Add(addexp);
            
        }

        private void gridViewBtn_Click(object sender, EventArgs e)
        {
            TypeComboBox.Enabled = true;
            Controlvisibility();
            datauc = new DataViewUc();
            int x = (int)((10.0 / 100.0) * DisplayPnl.Width);
            int y = (int)((10.0 / 100.0) * DisplayPnl.Height);
            datauc.Size = new Size((int)((85.0 / 100.0) * DisplayPnl.Width), (int)((80.0 / 100.0) * DisplayPnl.Height));
            datauc.Location = new Point(x, y);
            clearControls();
            datauc.displayDetails();
            DisplayPnl.Controls.Add(datauc);
        }

        private void clearControls()
        {
            foreach (Control ctrl in DisplayPnl.Controls)
            {
                if (ctrl != TypeComboBox && ctrl != symbolComboBox && ctrl != currSymLbl && ctrl != catTypeLbl)
                {
                    ctrl.Dispose();
                }
            }
        }

        private void ExpenseTrackerUc_Load(object sender, EventArgs e)
        {
           
        }

        private void symbolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.CurrencySymbol = symbolComboBox.SelectedItem.ToString();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datauc != null)
            {
                datauc.displayDetails();
                datauc.Category(TypeComboBox.SelectedItem.ToString());
            }
            filterUc2.PassCategory(TypeComboBox.SelectedItem.ToString());
            pIeChartUc1.Passcategory(TypeComboBox.SelectedItem.ToString());

        }

        

        private void pieBtn_Click(object sender, EventArgs e)
        {
            TypeComboBox.Enabled = true;
            Controlvisibility();
            piePnl.Visible = true;
        }

        private void FilterUc2_PassList(object sender, List<Expense> e)
        {
            pIeChartUc1.CalculatePie(e);
        }

        private void FilterUc2_PassIncome(object sender, List<Income> e)
        {
            pIeChartUc1.CalculatePie(e);
        }
        
        private void pIeChartUc1_Load(object sender, EventArgs e)
        {

        }

        private void remCatBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            remCatPnl.Visible = true;
            foreach(var item in DataManager.IncomecategoryDict)
            {
                listBox1.Items.Add(item.Key);
            }
            foreach (var item in DataManager.ExpensecategoryDict)
            {
                listBox2.Items.Add(item.Key);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DataManager.IncomecategoryDict.Remove(listBox1.SelectedItem.ToString());
            }
            if (listBox2.SelectedItem != null)
            {
                DataManager.ExpensecategoryDict.Remove(listBox2.SelectedItem.ToString());
            }
            MessageBox.Show("Category Removed Successfully...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controlvisibility();
        }
        
        
    }
}
