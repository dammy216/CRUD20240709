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
        private HistoryManager _instance = HistoryManager.Instance;
        public HistoryView()
        {
            InitializeComponent();
        }

        private void UpdateGridView()
        {
            historyGV.Rows.Clear();
            foreach(var history in _instance.HistoryList)
            {
                int rowIndex = historyGV.Rows.Add(_instance.GetHitoryItems(history));
                historyGV.Rows[rowIndex].Tag = history;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var add = new AddView();
            if(add.ShowDialog() == DialogResult.OK)
            {
                _instance.AddHistory();
                UpdateGridView();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _instance.RemoveHistory(historyGV.SelectedRows[0].Tag as History);
            UpdateGridView();
        }
    }
}
