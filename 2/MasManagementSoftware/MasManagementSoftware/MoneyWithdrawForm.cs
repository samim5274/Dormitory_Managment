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
    public partial class MoneyWithdrawForm : Form
    {
        public MoneyWithdrawForm()
        {
            InitializeComponent();
        }

        private void MoneyWithdrawForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            ClearText();
            FillGiver();
            FillReciver();
            FillPurpose();
            FillGridView();
            FillAmount();
        }

        private void FillAmount()
        {
            //Total Amount Calculate
            label7.Text = "0";
            for (int i = 0; i < dgvWithdraw.Rows.Count; i++)
            {
                label7.Text =
                    Convert.ToString(double.Parse(label7.Text) +
                                     double.Parse(dgvWithdraw.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void FillGridView()
        {
            var obj = new Manager();
            var list = obj.GetWithdrawGridView();
            dgvWithdraw.DataSource = list;
        }

        private void FillPurpose()
        {
            var obj = new Manager();
            var list = obj.GetAllPurpose();
            cbxPurpose.DisplayMember = "PurposeName";
            cbxPurpose.ValueMember = "PurposeId";
            cbxPurpose.DataSource = list;
        }

        private void FillReciver()
        {
            var obj = new Manager();
            var list = obj.GetAllReciver();
            cbxReciverName.DisplayMember = "Name";
            cbxReciverName.ValueMember = "Id";
            cbxReciverName.DataSource = list;
        }

        private void FillGiver()
        {
            var obj = new Manager();
            var list = obj.GetAllGiver();
            cbxGiverName.DisplayMember = "Name";
            cbxGiverName.ValueMember = "Id";
            cbxGiverName.DataSource = list;
        }

        private void ClearText()
        {
            cbxReciverName.Text = string.Empty;
            cbxPurpose.Text = string.Empty;
            cbxGiverName.Text = string.Empty;
            txtScarch.Text = string.Empty;
            txtMoney.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var DIP = new DipositMoneyDetail();

                DIP.Date = Convert.ToDateTime(dtpDate.Value);
                DIP.GiverId = Convert.ToInt32(cbxGiverName.SelectedValue);
                DIP.ReciverId = Convert.ToInt32(cbxReciverName.SelectedValue);
                DIP.PurposeId = Convert.ToInt32(cbxPurpose.SelectedValue);
                DIP.Credit_Money = Convert.ToDecimal(txtMoney.Text.Trim());
                DIP.Money = Convert.ToDecimal(txtDebitMoney.Text.Trim());

                DOR.AddToDipositMoneyDetails(DIP);
                DOR.SaveChanges();
                MessageBox.Show(@"Money Diposit Successfully.");
                ClearText();
                FillGridView();
                FillAmount();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Diposit money dosen't add.please try again.");
            }
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var SRC =
                    DOR.DipositMoneyDetails.ToList().Where(x => x.GiverId == int.Parse(txtScarch.Text.Trim())).
                        FirstOrDefault();

                dtpDate.Value = Convert.ToDateTime(SRC.Date);
                cbxGiverName.SelectedValue = SRC.GiverId;
                cbxReciverName.SelectedValue = SRC.ReciverId;
                cbxPurpose.SelectedValue = SRC.PurposeId;
                txtMoney.Text = SRC.Money.ToString();
                btnSave.Enabled = false;
                
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data not found.Please try again.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var SRC =
                    DOR.DipositMoneyDetails.ToList().Where(x => x.GiverId == int.Parse(txtScarch.Text.Trim())).
                        FirstOrDefault();

                SRC.Date = Convert.ToDateTime(dtpDate.Value);
                SRC.GiverId = Convert.ToInt32(cbxGiverName.SelectedValue);
                SRC.ReciverId = Convert.ToInt32(cbxReciverName.SelectedValue);
                SRC.PurposeId = Convert.ToInt32(cbxPurpose.SelectedValue);
                SRC.Credit_Money = Convert.ToDecimal(txtMoney.Text.Trim());
                btnSave.Enabled = false;

                DOR.SaveChanges();
                MessageBox.Show(@"Edit Successfully.");
                FillGridView();
                FillAmount();
                ClearText();
                btnSave.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Edit not possible.Please try again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var SRC =
                    DOR.DipositMoneyDetails.ToList().Where(x => x.GiverId == int.Parse(txtScarch.Text.Trim())).
                        FirstOrDefault();

                DOR.DeleteObject(SRC);
                DOR.SaveChanges();
                MessageBox.Show(@"Delet Successfully.");
                FillGridView();
                FillAmount();
                ClearText();
                btnSave.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data delete not possible.Please try again.");
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

        private void dgvWithdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
