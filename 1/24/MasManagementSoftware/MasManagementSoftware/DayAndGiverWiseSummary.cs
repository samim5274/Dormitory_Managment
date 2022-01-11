using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasManagementSoftware
{
    public partial class DayAndGiverWiseSummary : Form
    {
        public DayAndGiverWiseSummary()
        {
            InitializeComponent();
        }

        private void DayAndGiverWiseSummary_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            FillGiver();
        }

        private void FillGiver()
        {
            var obj = new Manager();
            var list = obj.GetAllGiver();
            cbxGiverName.DisplayMember = "Name";
            cbxGiverName.ValueMember = "Id";
            cbxGiverName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var STD = Convert.ToDateTime(dtpStart.Value);
            var END = Convert.ToDateTime(dtpEnd.Value);
            var GIV = Convert.ToInt32(cbxGiverName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetGiveAndDaySummary(STD,END,GIV);
            dgvDGs.DataSource = list;
            FillAmount();
        }

        private void FillAmount()
        {
            label6.Text = "0";
            for (int i = 0; i < dgvDGs.Rows.Count; i++)
            {
                label6.Text =
                    Convert.ToString(double.Parse(label6.Text) +
                                     double.Parse(dgvDGs.Rows[i].Cells[2].Value.ToString()));
            }
        }
    }
}
