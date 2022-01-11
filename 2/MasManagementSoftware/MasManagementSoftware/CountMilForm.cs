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
    public partial class CountMilForm : Form
    {
        public CountMilForm()
        {
            InitializeComponent();
        }

        private void CountMilForm_Load(object sender, EventArgs e)
        {
            dtpMilDate.Value = DateTime.Now;
            FillStudentName();
            Cleartext();
            FillMilGrid();
            FillTotalMil();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void FillTotalMil()
        {
            label6.Text = "0";
            for (int i = 0; i < dgvMil.Rows.Count; i++)
            {
                label6.Text =
                    Convert.ToString(double.Parse(label6.Text) +
                                     double.Parse(dgvMil.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void FillMilGrid()
        {
            var obj = new Manager();
            var list = obj.GetMilGrid();
            dgvMil.DataSource = list;
        }

        private void Cleartext()
        {
            cbxStudentName.Text = string.Empty;
        }

        private void FillStudentName()
        {
            var obj = new Manager();
            var list = obj.GettAllStudentName();
            cbxStudentName.DisplayMember = "Name";
            cbxStudentName.ValueMember = "Id";
            cbxStudentName.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var Mil = new MilInfoDetail();

                Mil.Date = Convert.ToDateTime(dtpMilDate.Value);
                Mil.StudentId = Convert.ToInt32(cbxStudentName.SelectedValue);
                Mil.Mil = Convert.ToInt32(txtMil.Text.Trim());

                DOR.AddToMilInfoDetails(Mil);
                DOR.SaveChanges();
                MessageBox.Show(@"Mil Submite Successfully.");
                Cleartext();
                FillMilGrid();
                FillTotalMil();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Mil Submited not possible.Please try again.Thank you !");
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Cleartext();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtMil.Text = dgvMil.SelectedRows[0].Cells[2].Value.ToString();
            cbxStudentName.Text = dgvMil.SelectedRows[0].Cells[1].Value.ToString();
            dtpMilDate.Text = dgvMil.SelectedRows[0].Cells[0].Value.ToString();

            btnSave.Visible = false;
            //btnUpdate.Visible = true;
            //btnDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var UDOR = new DORMITORYEntities();
                var DMIL = UDOR.MilInfoDetails.ToList().Where(x => x.Mil == int.Parse(txtMil.Text.Trim())).FirstOrDefault();

                DMIL.Date = Convert.ToDateTime(dtpMilDate.Value);
                DMIL.StudentId = Convert.ToInt32(cbxStudentName.SelectedValue);
                DMIL.Mil = Convert.ToInt32(txtMil.Text.Trim());

                UDOR.SaveChanges();
                MessageBox.Show(@"Update Successfully.");
                Cleartext();
                FillMilGrid();
                FillTotalMil();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Mil cann't update.Please try another way.Thank you!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DOR = new DORMITORYEntities();
            var DMIL = DOR.MilInfoDetails.ToList().Where(x => x.Mil == int.Parse(txtMil.Text.Trim())).FirstOrDefault();

            DOR.DeleteObject(DMIL);
            DOR.SaveChanges();
            MessageBox.Show(@"Delete Successfully.");
            Cleartext();
            FillMilGrid();
            FillTotalMil();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        
    }
}
