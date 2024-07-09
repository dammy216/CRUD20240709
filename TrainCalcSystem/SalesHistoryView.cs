using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainCalcSystem.Model;

namespace TrainCalcSystem
{
    public partial class SalesHistoryView : Form
    {
        private SalesManager _instance = SalesManager.Instance;
        public SalesHistoryView()
        {
            InitializeComponent();
            UpdateListViw();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateListViw()
        {
            historyLV.Items.Clear();
            foreach (var history in _instance.SaleList)
            {
                ListViewItem item = new ListViewItem(_instance.GetSalesItem(history));
                historyLV.Items.Add(item);  
            }
        }
    }
}
