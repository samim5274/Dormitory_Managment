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
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var DORobj = new DORMITORYEntities();
                var DepObj = new DepartmentInfo();

                DepObj.DepartmentName = txtAddDepartment.Text.Trim();

                DORobj.AddToDepartmentInfoes(DepObj);
                DORobj.SaveChanges();
                MessageBox.Show(@"Department name add successfully.");
                ClearTextbox();
                FillDepartment();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Please fill the text box.Thank you !!!");
            }
        }

        private void txtAddDepartment_TextChanged(object sender, EventArgs e)
        {
            if (txtAddDepartment.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void ClearTextbox()
        {
            txtAddDepartment.Text = string.Empty;
        }
    }
}
