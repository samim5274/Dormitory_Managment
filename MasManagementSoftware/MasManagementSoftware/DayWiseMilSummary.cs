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
    public partial class DayWiseMilSummary : Form
    {
        public DayWiseMilSummary()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var mngr = new Manager();
            var list = mngr.GetDayMilsummary(SD,ED);
            dgvDayWiseMilShow.DataSource = list;
            FilTotalDayMil();
            btnPrint.Enabled = true;
        }

        private void FilTotalDayMil()
        {
            label4.Text = "0";
            for (int i = 0; i < dgvDayWiseMilShow.Rows.Count; i++)
            {
                label4.Text =
                    Convert.ToString(double.Parse(label4.Text) +
                                     double.Parse(dgvDayWiseMilShow.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void DayWiseMilSummary_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            btnPrint.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var rpt = new rpt_DayWiseMilReport();
            var rptViewer = new RPT_DayWiseMilReportForm();
            rpt.SetParameterValue("@TODAY", SD);
            rpt.SetParameterValue("@TOMORROW", ED);
            rpt.DataSourceConnections.Clear();
            rptViewer.crystalReportViewer1.ReportSource = rpt;
            rptViewer.ShowDialog();
        }
    }
}
