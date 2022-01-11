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
    public partial class SemesterWiseDetailForm : Form
    {
        public SemesterWiseDetailForm()
        {
            InitializeComponent();
        }

        private void SemesterWiseDetailForm_Load(object sender, EventArgs e)
        {
            FillSemester();
        }

        private void FillSemester()
        {
            var obj = new Manager();
            var list = obj.GetAllSemister();
            cbxSemester.DisplayMember = "SemisterName";
            cbxSemester.ValueMember = "SemisterId";
            cbxSemester.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var ss = Convert.ToInt32(cbxSemester.SelectedValue);
            var obj = new Manager();
            var list = obj.GetSemester(ss);
            dgvSemester.DataSource = list;
        }
    }
}
