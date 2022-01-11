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
    public partial class DepartmentWiseDetailForm : Form
    {
        public DepartmentWiseDetailForm()
        {
            InitializeComponent();
        }

        private void DepartmentWiseDetailForm_Load(object sender, EventArgs e)
        {
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            var dep = Convert.ToInt32(cbxDepartment.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetDepartmentWiseDetail(dep);
            dgvDepartment.DataSource = list;
        }
    }
}
