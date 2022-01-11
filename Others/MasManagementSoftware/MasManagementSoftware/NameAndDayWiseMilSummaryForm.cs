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
    public partial class NameAndDayWiseMilSummaryForm : Form
    {
        public NameAndDayWiseMilSummaryForm()
        {
            InitializeComponent();
        }

        private void NameAndDayWiseMilSummaryForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillMilName();
            btnPrint.Enabled = false;
        }

        private void FillMilName()
        {
            var obj = new Manager();
            var list = obj.GettAllStudentName();
            cbxMilName.DisplayMember = "Name";
            cbxMilName.ValueMember = "Id";
            cbxMilName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var MN = Convert.ToInt32(cbxMilName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetNameAndDayMilSummary(SD,ED,MN);
            dgvDayAndNameWiseMilShow.DataSource = list;
            FillTotalMil();
            btnPrint.Enabled = true;
        }

        private void FillTotalMil()
        {
            label4.Text = "0";
            for (int i = 0; i < dgvDayAndNameWiseMilShow.Rows.Count; i++)
            {
                label4.Text =
                    Convert.ToString(double.Parse(label4.Text) +
                                     double.Parse(dgvDayAndNameWiseMilShow.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var MN = Convert.ToInt32(cbxMilName.SelectedValue);

            var rpt = new rpt_NameAndDayWiseSummaryReport();
            var rptViewer = new RPT_NameAndDayWisMilDetailReportViewerForm();

            rpt.SetParameterValue("@TODAY",SD);
            rpt.SetParameterValue("@TOMORROW",ED);
            rpt.SetParameterValue("@STUDENTNAME", MN);

            rpt.DataSourceConnections.Clear();
            rptViewer.crystalReportViewer1.ReportSource = rpt;

            rptViewer.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
