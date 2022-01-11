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
    public partial class DayByDayTotalAmountcs : Form
    {
        public DayByDayTotalAmountcs()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var STD = Convert.ToDateTime(dtpStartDate.Value);
            var END = Convert.ToDateTime(dtpEndDate.Value);
            var mngr = new Manager();
            var list = mngr.GetDayByDaySummary(STD, END);
            dgvDayWiseSummary.DataSource = list;

            FillDabitAmount();
            FillCaditAmount();
            //calculate total amount
            txtTotalAmount.Text = (float.Parse(label7.Text) - float.Parse(label5.Text)).ToString();
        }

        private void FillCaditAmount()
        {
            label5.Text = "0";
            for (int i = 0; i < dgvDayWiseSummary.Rows.Count; i++)
            {
                label5.Text =
                    Convert.ToString(double.Parse(label5.Text) +
                                     double.Parse(dgvDayWiseSummary.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void FillDabitAmount()
        {
            label7.Text = "0";
            for (int i = 0; i < dgvDayWiseSummary.Rows.Count; i++)
            {
                label7.Text =
                    Convert.ToString(double.Parse(label7.Text) +
                                     double.Parse(dgvDayWiseSummary.Rows[i].Cells[1].Value.ToString()));
            }
        }

        private void DayByDayTotalAmountcs_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
    }
}
