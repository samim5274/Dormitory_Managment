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
    public partial class SemesterShiftGenderAndDepartmentWiseDetailForm : Form
    {
        public SemesterShiftGenderAndDepartmentWiseDetailForm()
        {
            InitializeComponent();
        }

        private void SemesterShiftGenderAndDepartmentWiseDetailForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillSemester();
            FillShift();
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

        private void FillSemester()
        {
            var obj = new Manager();
            var list = obj.GetAllSemister();
            cbxSemester.DisplayMember = "SemisterName";
            cbxSemester.ValueMember = "SemisterId";
            cbxSemester.DataSource = list;
        }

        private void FillShift()
        {
            var obj = new Manager();
            var list = obj.GetAllShift();
            cbxShift.DisplayMember = "ShiftName";
            cbxShift.ValueMember = "ShiftId";
            cbxShift.DataSource = list;
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
            FillGridView();
        }

        private void FillGridView()
        {
            var Sem = Convert.ToInt32(cbxShift.SelectedValue);
            var Shf = Convert.ToInt32(cbxShift.SelectedValue);
            var Dep = Convert.ToInt32(cbxDepartment.SelectedValue);
            var Gen = Convert.ToInt32(cbxGender.SelectedValue);
            var obj = new Manager();
            var list = obj.GetGridViewReport(Sem, Shf, Dep, Gen);
            dgvDSSG.DataSource = list;
        }
    }
}
