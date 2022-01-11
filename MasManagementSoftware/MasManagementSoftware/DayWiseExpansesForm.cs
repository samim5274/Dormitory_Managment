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
    public partial class DayWiseExpansesForm : Form
    {
        public DayWiseExpansesForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var mngr = new Manager();
            var list = mngr.GetDayExpansesDetail(SD, ED);
            dgvExpansesDisplay.DataSource = list;
            FillGivenMoney();
            FillExpansesMoney();
            FillReturnMoney();
            btnPrint.Enabled = true;
        }

        private void FillGivenMoney()
        {
            label11.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label11.Text =
                    Convert.ToString(double.Parse(label11.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void FillExpansesMoney()
        {
            label15.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label15.Text =
                    Convert.ToString(double.Parse(label15.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void FillReturnMoney()
        {
            label13.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label13.Text =
                    Convert.ToString(double.Parse(label13.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var rpt = new rpt_DayWiseExpensesDetail();
            var retViewer = new RPT_DayWiseExpensesReportForm();
            rpt.SetParameterValue("@SDATE",SD);
            rpt.SetParameterValue("@EDATE", ED);
            rpt.DataSourceConnections.Clear();
            retViewer.crystalReportViewer1.ReportSource = rpt;
            retViewer.ShowDialog();
        }

        private void DayWiseExpansesForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            btnPrint.Enabled = false;
        }
    }
}
