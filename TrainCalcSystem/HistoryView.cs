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
    public partial class HistoryView : Form
    {
        private HistoryManager _historyInstance = HistoryManager.Instance;
        private SalesManager _salesInstance = SalesManager.Instance;
        public HistoryView()
        {
            InitializeComponent();
        }

        private void UpdateGridView()
        {
            historyGV.Rows.Clear();
            foreach(var history in _historyInstance.HistoryList)
            {
                int rowIndex = historyGV.Rows.Add(_historyInstance.GetHitoryItems(history));
                historyGV.Rows[rowIndex].Tag = history;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var add = new AddView();
            if(add.ShowDialog() == DialogResult.OK)
            {
                _historyInstance.AddHistory();
                UpdateGridView();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _historyInstance.RemoveHistory(historyGV.SelectedRows[0].Tag as History);
            UpdateGridView();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            _salesInstance.AddSales(historyGV.SelectedRows[0].Tag as History);
            _historyInstance.RemoveHistory(historyGV.SelectedRows[0].Tag as History);
            UpdateGridView();
        }

        private void toBuyHistoryBtn_Click(object sender, EventArgs e)
        {
            var sales = new SalesHistoryView();
            sales.ShowDialog();
        }
    }
}
