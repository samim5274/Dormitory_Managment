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
    public partial class SemesterAndGenderform : Form
    {
        public SemesterAndGenderform()
        {
            InitializeComponent();
        }

        private void SemesterAndGenderform_Load(object sender, EventArgs e)
        {
            FillGender();
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
            var sem = Convert.ToInt32(cbxSemester.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetSemesterAndGender(gen,sem);
            dgvSemAndGen.DataSource = list;
        }
    }
}
