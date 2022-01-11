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
    public partial class ExpansesPaidForm : Form
    {
        public ExpansesPaidForm()
        {
            InitializeComponent();
        }

        private void ExpansesPaidForm_Load(object sender, EventArgs e)
        {
            dtpExDate.Value = DateTime.Now;
            FillStudentName();
            ClearText();
            FillExpansesGrid();
            FillGivenMoney();
            FillExpansesMoney();
            FillReturnMoney();
        }

        private void FillReturnMoney()
        {
            label13.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label13.Text =
                    Convert.ToString(double.Parse(label13.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void FillExpansesMoney()
        {
            label15.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label15.Text =
                    Convert.ToString(double.Parse(label15.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[5].Value.ToString()));
            }
        }

        private void FillGivenMoney()
        {
            label11.Text = "0";
            for (int i = 0; i < dgvExpansesDisplay.Rows.Count; i++)
            {
                label11.Text =
                    Convert.ToString(double.Parse(label11.Text) +
                                     double.Parse(dgvExpansesDisplay.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void FillExpansesGrid()
        {
            var obj = new Manager();
            var list = obj.GetExpansesGrid();
            dgvExpansesDisplay.DataSource = list;
        }

        private void ClearText()
        {
            cbxStudentName.Text = string.Empty;
            txtExName.Text = string.Empty;
            txtExpanserName.Text = string.Empty;
            txtGiveMoney.Text = string.Empty;
            txtExMoney.Text = string.Empty;
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
                var EXDOR = new DORMITORYEntities();
                var EX = new ExpenditureDetail();

                EX.Date = Convert.ToDateTime(dtpExDate.Value);
                EX.StudentId = Convert.ToInt32(cbxStudentName.SelectedValue);
                EX.WhichOneName = txtExpanserName.Text.Trim();
                EX.ExpansesName = txtExName.Text.Trim();
                EX.GivenMoney = Convert.ToDecimal(txtGiveMoney.Text.Trim());
                EX.ExpansesMoney = Convert.ToDecimal(txtExMoney.Text.Trim());
                EX.ReturnMoney = Convert.ToDecimal(txtReturnMoney.Text.Trim());

                EXDOR.AddToExpenditureDetails(EX);
                EXDOR.SaveChanges();
                MessageBox.Show(@"Expanses Paid Successfully.");
                ClearText();
                FillExpansesGrid();
                FillGivenMoney();
                FillExpansesMoney();
                FillReturnMoney();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Expanses paid not possible.Please try again.Thank you!");
            }
        }

        private void txtExMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtReturnMoney.Text = (float.Parse(txtGiveMoney.Text) - float.Parse(txtExMoney.Text)).ToString();
            }
            catch (Exception)
            {
                txtReturnMoney.Text = string.Empty;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
