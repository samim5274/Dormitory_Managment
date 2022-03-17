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
    public partial class DayAndNameWiseExpansesForm : Form
    {
        public DayAndNameWiseExpansesForm()
        {
            InitializeComponent();
        }

        private void DayAndNameWiseExpansesForm_Load(object sender, EventArgs e)
        {
            FillName();
        }

        private void FillName()
        {
            var obj = new Manager();
            var list = obj.GettAllStudentName();
            cbxName.DisplayMember = "Name";
            cbxName.ValueMember = "Id";
            cbxName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var EN = Convert.ToInt32(cbxName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetDayAndNamewiseExDetail(SD,ED,EN);
            dgvExNameAndDay.DataSource = list;
            FillGiven();
            FillExpanses();
            FillReturn();
        }

        private void FillGiven()
        {
            label11.Text = "0";
            for (int i = 0; i < dgvExNameAndDay.Rows.Count; i++)
            {
                label11.Text =
                    Convert.ToString(double.Parse(label11.Text) +
                                     double.Parse(dgvExNameAndDay.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void FillExpanses()
        {
            label15.Text = "0";
            for (int i = 0; i < dgvExNameAndDay.Rows.Count; i++)
            {
                label15.Text =
                    Convert.ToString(double.Parse(label15.Text) +
                                     double.Parse(dgvExNameAndDay.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void FillReturn()
        {
            label13.Text = "0";
            for (int i = 0; i < dgvExNameAndDay.Rows.Count; i++)
            {
                label13.Text =
                    Convert.ToString(double.Parse(label13.Text) +
                                     double.Parse(dgvExNameAndDay.Rows[i].Cells[5].Value.ToString()));
            }
        }
    }
}
