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
    public partial class ShiftAndDepartmentForm : Form
    {
        public ShiftAndDepartmentForm()
        {
            InitializeComponent();
        }

        private void ShiftAndDepartmentForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillShift();
        }

        private void FillShift()
        {
            var obj = new Manager();
            var list = obj.GetAllShift();
            cbxShift.DisplayMember = "ShiftName";
            cbxShift.ValueMember = "ShiftId";
            cbxShift.DataSource = list;
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
            var shif = Convert.ToInt32(cbxShift.SelectedValue);
            var dep = Convert.ToInt32(cbxDepartment.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetShiftAndDepartment(shif,dep);
            dgvDepAndShift.DataSource = list;
        }
    }
}
