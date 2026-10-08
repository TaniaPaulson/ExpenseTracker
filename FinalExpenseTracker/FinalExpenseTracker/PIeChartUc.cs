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
    public partial class PIeChartUc : UserControl
    {
        public PIeChartUc()
        {
            InitializeComponent();
            //int x = (int)((70.0 / 100.0) * this.Width);
            //int y = (int)((10.0 / 100.0) * this.Height);
            //int h= (int)((40.0 / 100.0) * this.Height);
            //int w = (int)((20.0 / 100.0) * this.Width);
            //colorGuidePnl.Location = new Point(x, y);
            //colorGuidePnl.Size = new Size(w, h);
        }

        Dictionary<string, double> expensetotal = new Dictionary<string, double>();

        Dictionary<string, double> incometotal = new Dictionary<string, double>();

        double exptotal;
        double inctotal;

        string cat;

        private void PIeChartUc_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = (int)((30.0 / 100.0) * this.Width);
            int y = (int)((20.0 / 100.0) * this.Height);
            int h = (int)((70.0 / 100.0) * this.Height);
            int w = (int)((70.0 / 100.0) * this.Height);
            Rectangle r = new Rectangle(x, y, w, h);
            double oldsweep = 0;
            int start = 0;
            colorGuidePnl.Controls.Clear();
            if (cat == "EXPENSE")
            {
                foreach (var entry in expensetotal)
                {
                    double newsweep = (entry.Value / exptotal) * 360;
                    using (SolidBrush sb = new SolidBrush(DataManager.ExpensecategoryDict[entry.Key].color))
                    {
                        g.FillPie(sb, r, (float)oldsweep, (float)newsweep);
                        oldsweep += newsweep;

                        Label colorLabel = new Label
                        {
                            BackColor = sb.Color,
                            Size = new Size(23, 23),
                            Location = new Point(0, start)
                        };
                        colorGuidePnl.Controls.Add(colorLabel);

                        Label textLabel = new Label
                        {
                            Location = new Point(colorLabel.Location.X + colorLabel.Width, colorLabel.Location.Y),
                            Text = entry.Key,
                            Font = new Font("Times New Roman", 11),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        colorGuidePnl.Controls.Add(textLabel);

                        start = colorLabel.Location.Y + colorLabel.Height + 2;
                    }
                }
            }
            if (cat == "INCOME")
            {
                foreach (var entry in incometotal)
                {
                    double newsweep = (entry.Value / inctotal) * 360;
                    using (SolidBrush sb = new SolidBrush(DataManager.IncomecategoryDict[entry.Key]))
                    {
                        g.FillPie(sb, r, (float)oldsweep, (float)newsweep);
                        oldsweep += newsweep;

                        Label colorLabel = new Label
                        {
                            BackColor = sb.Color,
                            Size = new Size(23, 23),
                            Location = new Point(0, start)
                        };
                        colorGuidePnl.Controls.Add(colorLabel);

                        Label textLabel = new Label
                        {
                            Location = new Point(colorLabel.Location.X + colorLabel.Width, colorLabel.Location.Y),
                            Text = entry.Key,
                            Font = new Font("Times New Roman", 11),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        colorGuidePnl.Controls.Add(textLabel);

                        start = colorLabel.Location.Y + colorLabel.Height + 2;
                    }
                }
            }
            double margin = 0.10;

            int innerWidth = (int)(w * (1 - 2 * margin));
            int innerHeight = (int)(h * (1 - 2 * margin));
            int innerX = x + (int)(w * margin);
            int innerY = y + (int)(h * margin);
            Rectangle ir = new Rectangle(innerX, innerY, innerWidth, innerHeight);
            using (SolidBrush s = new SolidBrush(Color.White))
            {
                g.FillEllipse(s, ir);
            }
        }



        internal void CalculatePie(List<Expense> expenses)
        {
            exptotal = 0;
            expensetotal.Clear();
            exptotal = expenses.Sum(exp => exp.Amount);
            foreach (var group in expenses.GroupBy(e => e.Category))
            {
                expensetotal[group.Key] = group.Sum(e => e.Amount);
            }
            this.Invalidate();
        }

        internal void CalculatePie(List<Income> income)
        {
            inctotal = 0;
            incometotal.Clear();
            inctotal = income.Sum(inc => inc.Amount);
            foreach (var group in income.GroupBy(e => e.Category))
            {
                incometotal[group.Key] = group.Sum(e => e.Amount);
            }
            this.Invalidate();
        }

        internal void Passcategory(string v)
        {
            cat = v;
        }
    }
}
