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
    public partial class dgvMilDisplay : Form
    {
        public dgvMilDisplay()
        {
            InitializeComponent();
        }

        private void NameWiseMilSummaryForm_Load(object sender, EventArgs e)
        {
            FillName();
        }

        private void FillName()
        {
            var obj = new Manager();
            var list = obj.GettAllStudentName();
            cbxMilName.DisplayMember = "Name";
            cbxMilName.ValueMember = "Id";
            cbxMilName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var Nam = Convert.ToInt32(cbxMilName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetMilDisplay(Nam);
            dgvNameWiseGrid.DataSource = list;
            FillTotalMil();
        }

        private void FillTotalMil()
        {
            label4.Text = "0";
            for (int i = 0; i < dgvNameWiseGrid.Rows.Count; i++)
            {
                label4.Text =
                    Convert.ToString(double.Parse(label4.Text) +
                                     double.Parse(dgvNameWiseGrid.Rows[i].Cells[2].Value.ToString()));
            }
        }
    }
}
