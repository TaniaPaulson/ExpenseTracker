using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalExpenseTracker
{
    public static class DataManager
    {
        public static Dictionary<string, (Color color, int budget)> ExpensecategoryDict = new Dictionary<string, (Color color, int budget)>();
        public static Dictionary<string, Color> IncomecategoryDict = new Dictionary<string, Color>();

        public static List<Expense> expenselist = new List<Expense>();
        public static List<Income> incomelist = new List<Income>();
        
        public static string CurrencySymbol { get; set; } = "$";
        
        public static void AddExpe()
        {

        }
        
    }
}
