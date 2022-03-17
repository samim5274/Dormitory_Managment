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
    public partial class GenderWiseDetailForm : Form
    {
        public GenderWiseDetailForm()
        {
            InitializeComponent();
        }

        private void GenderWiseDetailForm_Load(object sender, EventArgs e)
        {
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            var gen = Convert.ToInt32(cbxGender.SelectedValue);
            var obj = new Manager();
            var list = obj.GetGenderDetail(gen);
            dgvGender.DataSource = list;
        }
    }
}
