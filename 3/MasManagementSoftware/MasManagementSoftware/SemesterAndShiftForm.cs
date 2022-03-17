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
    public partial class SemesterAndShiftForm : Form
    {
        public SemesterAndShiftForm()
        {
            InitializeComponent();
        }

        private void SemesterAndShiftForm_Load(object sender, EventArgs e)
        {
            FillShift();
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

        private void FillShift()
        {
            var obj = new Manager();
            var list = obj.GetAllShift();
            cbxShift.DisplayMember = "ShiftName";
            cbxShift.ValueMember = "ShiftId";
            cbxShift.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var sem = Convert.ToInt32(cbxSemester.SelectedValue);
            var shif = Convert.ToInt32(cbxShift.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetSemesterandShift(sem,shif);
            dgvShiftAndSem.DataSource = list;
        }
    }
}
