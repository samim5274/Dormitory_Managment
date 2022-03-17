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
    public partial class GenderAndShiftForm : Form
    {
        public GenderAndShiftForm()
        {
            InitializeComponent();
        }

        private void GenderAndShiftForm_Load(object sender, EventArgs e)
        {
            FillShift();
            FillGender();
        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "GenderName";
            cbxGender.ValueMember = "GenderId";
            cbxGender.DataSource = list;
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
            var gen = Convert.ToInt32(cbxGender.SelectedValue);
            var shif = Convert.ToInt32(cbxShift.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetGenderAndShift(gen,shif);
            dgvShiftAndGen.DataSource = list;
        }
    }
}
