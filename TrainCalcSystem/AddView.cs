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
    public partial class AddView : Form
    {
        private HistoryManager _instance = HistoryManager.Instance;
        public AddView()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(distanceTB.Text, out int distance);
            _instance.GetHistoryData(trainCB.Text, seatCB.Text, distance);
            DialogResult = DialogResult.OK;
        }

        private void distanceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // 数字またはバックスペースは許可する
            }
            else
                e.Handled = true; // その他の文字は拒否する
        }

        private void radio()
        {
            var radio = Controls.OfType<RadioButton>().FirstOrDefault(item => item.Checked);
        }
    }
}
