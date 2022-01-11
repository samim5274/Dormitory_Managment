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
    public partial class MilRateForm : Form
    {
        public MilRateForm()
        {
            InitializeComponent();
        }

        private void MilRateForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillStudentName();
            btnSingelPersonInfo.Enabled = false;
        }

        private void FillStudentName()
        {
            var obj = new Manager();
            var list = obj.GettAllStudentName();
            cbxStudentName.DisplayMember = "Name";
            cbxStudentName.ValueMember = "Id";
            cbxStudentName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);

            var mngr = new Manager();
            var list = mngr.GetTotalMil(SD,ED);
            dgvTotalMil.DataSource = list;

            var mngr1 = new Manager();
            var list1 = mngr1.GetTotalExpanses(SD,ED);
            dgvExTotal.DataSource = list1;

            FillTotalMil();
            FillExTotal();

            txtMilRate.Text = (float.Parse(lblTotalExpanses.Text) / float.Parse(lblTotalMil.Text)).ToString();
            btnSingelPersonInfo.Enabled = true;
        }

        private void FillExTotal()
        {
            lblTotalExpanses.Text = "0";
            for (int i = 0; i < dgvExTotal.Rows.Count; i++)
            {
                lblTotalExpanses.Text =
                    Convert.ToString(double.Parse(lblTotalExpanses.Text) +
                                     double.Parse(dgvExTotal.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void FillTotalMil()
        {
            lblTotalMil.Text = "0";
            for (int i = 0; i < dgvTotalMil.Rows.Count; i++)
            {
                lblTotalMil.Text =
                    Convert.ToString(double.Parse(lblTotalMil.Text) +
                                     double.Parse(dgvTotalMil.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void btnSingelPersonInfo_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var SN = Convert.ToInt32(cbxStudentName.SelectedValue);

            var mngr2 = new Manager();
            var list2 = mngr2.GetSingelPersonMil(SD,ED,SN);
            dgvSingelPersonMil.DataSource = list2;

            var mngr3 = new Manager();
            var list3 = mngr3.GetSingelPersonDipositMoney(SD,ED,SN);
            dgvsingelPersonDipositMoney.DataSource = list3;

            var mnger4 = new Manager();
            var list4 = mnger4.GettWithdrawDetail(SD, ED, SN);
            dgvWithdraw.DataSource = list4;

            FillSingelMil();
            FillSIngerPersonDipoMoney();
            FillTotalDiposit();

            txtTotal.Text = (float.Parse(lblSingelPersolDipoMoney.Text) - float.Parse(lblTotaWithdraw.Text)).ToString();

            txtTotalAmount.Text = (float.Parse(txtMilRate.Text) * float.Parse(lblSingelPersonMil.Text)).ToString();

            txtGiveOrTake.Text = (float.Parse(txtTotal.Text) - float.Parse(txtTotalAmount.Text)).ToString();
        }

        private void FillTotalDiposit()
        {
            lblTotaWithdraw.Text = "0";
            for (int i = 0; i < dgvWithdraw.Rows.Count; i++)
            {
                lblTotaWithdraw.Text =
                    Convert.ToString(double.Parse(lblTotaWithdraw.Text) +
                                     double.Parse(dgvWithdraw.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void FillSingelMil()
        {
            lblSingelPersonMil.Text = "0";
            for (int i = 0; i < dgvSingelPersonMil.Rows.Count; i++)
            {
                lblSingelPersonMil.Text =
                    Convert.ToString(double.Parse(lblSingelPersonMil.Text) +
                                     double.Parse(dgvSingelPersonMil.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void FillSIngerPersonDipoMoney()
        {
            lblSingelPersolDipoMoney.Text = "0";
            for (int i = 0; i < dgvsingelPersonDipositMoney.Rows.Count; i++)
            {
                lblSingelPersolDipoMoney.Text =
                    Convert.ToString(double.Parse(lblSingelPersolDipoMoney.Text) +
                                     double.Parse(dgvsingelPersonDipositMoney.Rows[i].Cells[0].Value.ToString()));
            }
        }
    }
}
