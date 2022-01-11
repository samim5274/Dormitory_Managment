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
    public partial class TotalAmountLastForm : Form
    {
        public TotalAmountLastForm()
        {
            InitializeComponent();
        }

        private void TotalAmountLastForm_Load(object sender, EventArgs e)
        {
            dtpSDate.Value = DateTime.Now;
            dtpEDate.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SDate = Convert.ToDateTime(dtpSDate.Value);
            var EDate = Convert.ToDateTime(dtpEDate.Value);
            var mngr = new Manager();
            var list = mngr.GetLastExpenses(SDate,EDate);
            dgvLastExpenses.DataSource = list;
            var list1 = mngr.GetLastTotal(SDate, EDate);
            dgvLastTotal.DataSource = list1;
            FillDiposit();
            FillWithdraw();
            FillExpenses();
            lblClosingDipo.Text = (float.Parse(lblTotalDipo.Text) - float.Parse(lblTotalWithdraw.Text)).ToString();
            lblTotalClosingCash.Text = (float.Parse(lblClosingDipo.Text) - float.Parse(lblTotalExpenses.Text)).ToString();
        }

        private void FillExpenses()
        {
            lblTotalExpenses.Text = "0";
            for (int i = 0; i < dgvLastExpenses.Rows.Count; i++)
            {
                lblTotalExpenses.Text =
                    Convert.ToString(double.Parse(lblTotalExpenses.Text) +
                                     double.Parse(dgvLastExpenses.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void FillDiposit()
        {
            lblTotalDipo.Text = "0";
            for (int i = 0; i < dgvLastTotal.Rows.Count; i++)
            {
                lblTotalDipo.Text =
                    Convert.ToString(double.Parse(lblTotalDipo.Text) +
                                     double.Parse(dgvLastTotal.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void FillWithdraw()
        {
            lblTotalWithdraw.Text = "0";
            for (int i = 0; i < dgvLastTotal.Rows.Count; i++)
            {
                lblTotalWithdraw.Text =
                    Convert.ToString(double.Parse(lblTotalWithdraw.Text) +
                                     double.Parse(dgvLastTotal.Rows[i].Cells[1].Value.ToString()));
            }
        }
        
    }
}
