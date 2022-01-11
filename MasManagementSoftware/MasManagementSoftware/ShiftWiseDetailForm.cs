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
    public partial class ShiftWiseDetailForm : Form
    {
        public ShiftWiseDetailForm()
        {
            InitializeComponent();
        }

        private void ShiftWiseDetailForm_Load(object sender, EventArgs e)
        {
            FilShift();
        }

        private void FilShift()
        {
            var obj = new Manager();
            var list = obj.GetAllShift();
            cbxShift.DisplayMember = "ShiftName";
            cbxShift.ValueMember = "ShiftId";
            cbxShift.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var shf = Convert.ToInt32(cbxShift.SelectedValue);
            var obj = new Manager();
            var list = obj.GetShiftDetail(shf);
            dgvShift.DataSource = list;
        }
    }
}
