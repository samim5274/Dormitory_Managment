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
    public partial class AddStudentInformatio : Form
    {
        public AddStudentInformatio()
        {
            InitializeComponent();
        }
        
        private void AddStudentInformatio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dORMITORYDataSet.SP_GRIDVIEWDISPLAY' table. You can move, or remove it, as needed.
            this.sP_GRIDVIEWDISPLAYTableAdapter.Fill(this.dORMITORYDataSet.SP_GRIDVIEWDISPLAY);

            dtpDateOfBirth.Value = DateTime.Now;
            FillDepartment();
            FillShift();
            FillSemister();
            FillGender();
            btnSave.Enabled = false;
            Cleartextbox();
            FillGrid();
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GettGridView();
            dgvStudentInfo.DataSource = list;
        }

        private void Cleartextbox()
        {
            txtName.Text = string.Empty;
            txtRoll.Text = string.Empty;
            txtRegistration.Text = string.Empty;
            cbxDepartment.Text = string.Empty;
            cbxGender.Text = string.Empty;
            cbxSemister.Text = string.Empty;
            cbxShift.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtScarch.Text = string.Empty;
        }

        private void FillGender()
        {
            var Manager = new Manager();
            var list = new Manager().GetAllGender();
            cbxGender.DisplayMember = "GenderName";
            cbxGender.ValueMember = "GenderId";
            cbxGender.DataSource = list;
        }

        private void FillSemister()
        {
            var Manager = new Manager();
            var list = new Manager().GetAllSemister();
            cbxSemister.DisplayMember = "SemisterName";
            cbxSemister.ValueMember = "SemisterId";
            cbxSemister.DataSource = list;
        }

        private void FillShift()
        {
            var Manager = new DORMITORYEntities();
            var list = new Manager().GetAllShift();
            cbxShift.DisplayMember = "ShiftName";
            cbxShift.ValueMember = "ShiftId";
            cbxShift.DataSource = list;
        }

        private void FillDepartment()
        {
            var Manager = new DORMITORYEntities();
            var list = new Manager().GettAllDepartmetn();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var DOR = new DORMITORYEntities();
            var INFO = new StudentInformation();

            INFO.Name = txtName.Text.Trim();
            INFO.Roll = Convert.ToInt32(txtRoll.Text.Trim());
            INFO.Registration = Convert.ToInt32(txtRegistration.Text.Trim());
            INFO.SemisterId = Convert.ToInt32(cbxSemister.SelectedValue);
            INFO.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);
            INFO.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
            INFO.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
            INFO.Address = txtAddress.Text.Trim();
            INFO.Phone = Convert.ToInt32(txtPhone.Text.Trim());
            INFO.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);

            DOR.AddToStudentInformations(INFO);
            DOR.SaveChanges();
            MessageBox.Show(@"Student information has been save successfully.");
            Cleartextbox();
            FillGrid();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Cleartextbox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void btnScarch_Click_1(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                //var INFO = DOR.StudentInformations.ToList().Where(x => x.Roll == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                var INFO = DOR.StudentInformations.ToList().Where(x => x.Name == txtScarch.Text).FirstOrDefault();

                txtName.Text = INFO.Name;
                txtRoll.Text = INFO.Roll.ToString();
                txtRegistration.Text = INFO.Registration.ToString();
                txtPhone.Text = INFO.Phone.ToString();
                txtAddress.Text = INFO.Address;
                dtpDateOfBirth.Value = Convert.ToDateTime(INFO.DateOfBirth);
                cbxDepartment.SelectedValue = INFO.DepartmentId;
                cbxGender.SelectedValue = INFO.GenderId;
                cbxSemister.SelectedValue = INFO.SemisterId;
                cbxShift.SelectedValue = INFO.ShiftId;
                btnSave.Enabled = false;
            }
            catch
            {
                //MessageBox.Show(@"Data not found ! you can input Roll number and try again.Thank you.");
                var DOR = new DORMITORYEntities();
                var INFO = DOR.StudentInformations.ToList().Where(x => x.Roll == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();
                //var INFO = DOR.StudentInformations.ToList().Where(x => x.Name == txtScarch.Text).FirstOrDefault();

                txtName.Text = INFO.Name;
                txtRoll.Text = INFO.Roll.ToString();
                txtRegistration.Text = INFO.Registration.ToString();
                txtPhone.Text = INFO.Phone.ToString();
                txtAddress.Text = INFO.Address;
                dtpDateOfBirth.Value = Convert.ToDateTime(INFO.DateOfBirth);
                cbxDepartment.SelectedValue = INFO.DepartmentId;
                cbxGender.SelectedValue = INFO.GenderId;
                cbxSemister.SelectedValue = INFO.SemisterId;
                cbxShift.SelectedValue = INFO.ShiftId;
                btnSave.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DOR = new DORMITORYEntities();
            var INFO = DOR.StudentInformations.ToList().Where(x => x.Roll == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

            DOR.DeleteObject(INFO);
            DOR.SaveChanges();
            MessageBox.Show(@"Data has been Deleted successfully.");
            Cleartextbox();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var DOR = new DORMITORYEntities();
            var INFO = DOR.StudentInformations.ToList().Where(x => x.Roll == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

            INFO.Name = txtName.Text.Trim();
            INFO.Roll = Convert.ToInt32(txtRoll.Text.Trim());
            INFO.Registration = Convert.ToInt32(txtRegistration.Text.Trim());
            INFO.SemisterId = Convert.ToInt32(cbxSemister.SelectedValue);
            INFO.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);
            INFO.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
            INFO.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
            INFO.Address = txtAddress.Text.Trim();
            INFO.Phone = Convert.ToInt32(txtPhone.Text.Trim());
            INFO.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);

            //DOR.AddToStudentInformations(INFO);
            DOR.SaveChanges();
            MessageBox.Show(@"Student information has been Update successfully.");
            Cleartextbox();
            FillGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
            //var obj = new ReportForm();
            //obj.ShowDialog();
            
            var rpt = new rpt_StudentInforReport();
            var reportViewer = new RPT_ReportForm();
            //reportViewer.crystalReportViewer1.Show();
            rpt.DataSourceConnections.Clear();
            reportViewer.crystalReportViewer1.ReportSource = rpt;
            reportViewer.ShowDialog();
        }

       private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mass Managment System", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(160, 50));

            e.Graphics.DrawString("Student Information", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(250, 100));

            e.Graphics.DrawString("SAMIM Hossen", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(320, 150));

            e.Graphics.DrawString("E-mail:samim.hossen5274@gmail.com", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(240, 185));

            e.Graphics.DrawString("Phone: 01762-164746,01533021557", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(280, 220));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, 245));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 275));

            e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 290));

            e.Graphics.DrawString("Roll", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 290));

            e.Graphics.DrawString("Reg", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 290));

            e.Graphics.DrawString("Department", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 290));

            e.Graphics.DrawString("Semister", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 290));

            e.Graphics.DrawString("Phone", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(680, 290));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 300));

            //int y = 320;
            //foreach (var obj in )
            //{
            //    e.Graphics.DrawString(obj. , new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, y));
            //}

            //selected item print
            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 320));

            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 320));

            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 320));

            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 320));

            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 320));

            e.Graphics.DrawString("" + dgvStudentInfo.SelectedRows[0].Cells[6].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(680, 320));
        }

       private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }
    }
}
