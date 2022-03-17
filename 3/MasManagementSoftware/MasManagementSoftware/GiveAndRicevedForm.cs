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
    public partial class GiveAndRicevedForm : Form
    {
        public GiveAndRicevedForm()
        {
            InitializeComponent();
        }

        private void GiveAndRiceved_Load(object sender, EventArgs e)
        {
            FillGiver();
            FillReciver();
        }

        private void FillReciver()
        {
            var obj = new Manager();
            var list = obj.GetAllGiver();
            cbxTotalGiver.DisplayMember = "Name";
            cbxTotalGiver.ValueMember = "Id";
            cbxTotalGiver.DataSource = list;
        }

        private void FillGiver()
        {
            var obj = new Manager();
            var list = obj.GetAllGiver();
            cbxTotalRicever.DisplayMember = "Name";
            cbxTotalRicever.ValueMember = "Id";
            cbxTotalRicever.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var GIV = Convert.ToInt32(cbxTotalGiver.SelectedValue);
            var RIC = Convert.ToInt32(cbxTotalRicever.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetGiverAndRicever(GIV, RIC);
            dgvGiveAndRiceve.DataSource = list;

            FillDabitAmount();
            FillCraditAmount();

            //calculate total amount
            txtTotalAmount.Text = (float.Parse(label3.Text) - float.Parse(label5.Text)).ToString();
        }

        private void FillDabitAmount()
        {
            label3.Text = "0";
            for (int i = 0; i < dgvGiveAndRiceve.Rows.Count; i++)
            {
                label3.Text =
                    Convert.ToString(double.Parse(label3.Text) +
                                     double.Parse(dgvGiveAndRiceve.Rows[i].Cells[1].Value.ToString()));
            }
        }

        private void FillCraditAmount()
        {
            label5.Text = "0";
            for (int i = 0; i < dgvGiveAndRiceve.Rows.Count; i++)
            {
                label5.Text =
                    Convert.ToString(double.Parse(label5.Text) +
                                     double.Parse(dgvGiveAndRiceve.Rows[i].Cells[2].Value.ToString()));
            }
        }
    }
}
