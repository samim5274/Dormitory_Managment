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
    public partial class SemesterAndDepartmentForm : Form
    {
        public SemesterAndDepartmentForm()
        {
            InitializeComponent();
        }

        private void SemesterAndDepartmentForm_Load(object sender, EventArgs e)
        {
            FillSemester();
            FillDepartment();
        }

        private void FillDepartment()
        {
            var obj = new Manager();
            var list = obj.GettAllDepartmetn();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.DataSource = list;
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
            var sem = Convert.ToInt32(cbxSemester.SelectedValue);
            var dep = Convert.ToInt32(cbxDepartment.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetSemesterAndDepartment(sem,dep);
            dgvSemAndDep.DataSource = list;
        }
    }
}
