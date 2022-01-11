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
    public partial class DepartmentAndGenderWiseDetailForm : Form
    {
        public DepartmentAndGenderWiseDetailForm()
        {
            InitializeComponent();
        }

        private void DepartmentAndGenderWiseDetailForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillGender();
        }

        private void FillDepartment()
        {
            var obj = new Manager();
            var list = obj.GettAllDepartmetn();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.DataSource = list;
        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "GenderName";
            cbxGender.ValueMember = "GenderId";
            cbxGender.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var gen = Convert.ToInt32(cbxGender.SelectedValue);
            var dep = Convert.ToInt32(cbxDepartment.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetGenderAndDepartmentDetail(gen,dep);
            dgvDepAndGen.DataSource = list;
        }
    }
}
