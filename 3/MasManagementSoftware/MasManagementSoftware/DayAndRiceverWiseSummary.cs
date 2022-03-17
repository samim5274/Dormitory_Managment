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
    public partial class DayAndRiceverWiseSummary : Form
    {
        public DayAndRiceverWiseSummary()
        {
            InitializeComponent();
        }

        private void DayAndRiceverWiseSummary_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            FillRicever();
        }

        private void FillRicever()
        {
            var obj = new Manager();
            var list = obj.GetAllReciver();
            cbxRiceverName.DisplayMember = "Name";
            cbxRiceverName.ValueMember = "Id";
            cbxRiceverName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var STD = Convert.ToDateTime(dtpStart.Value);
            var END = Convert.ToDateTime(dtpEnd.Value);
            var GIV = Convert.ToInt32(cbxRiceverName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetRiceverAndDaySummary(STD, END, GIV);
            dgvDRs.DataSource = list;
            FillAmount();
        }

        private void FillAmount()
        {
            label6.Text = "0";
            for (int i = 0; i < dgvDRs.Rows.Count; i++)
            {
                label6.Text =
                    Convert.ToString(double.Parse(label6.Text) +
                                     double.Parse(dgvDRs.Rows[i].Cells[3].Value.ToString()));
            }
        }
    }
}
