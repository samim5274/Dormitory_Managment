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
    public partial class PurposeWiseForm : Form
    {
        public PurposeWiseForm()
        {
            InitializeComponent();
        }

        private void PurposeWiseForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            FillPurpose();
        }

        private void FillDebit()
        {
            label11.Text = "0";
            for (int i = 0; i < dgvPurposeAndDay.Rows.Count; i++)
            {
                label11.Text =
                    Convert.ToString(double.Parse(label11.Text) +
                                     double.Parse(dgvPurposeAndDay.Rows[i].Cells[1].Value.ToString()));
            }
        }

        private void FillCradit()
        {
            label13.Text = "0";
            for (int i = 0; i < dgvPurposeAndDay.Rows.Count; i++)
            {
                label13.Text =
                    Convert.ToString(double.Parse(label13.Text) +
                                     double.Parse(dgvPurposeAndDay.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void FillPurpose()
        {
            var obj = new Manager();
            var list = obj.GetAllPurpose();
            cbxPurposeName.DisplayMember = "PurposeName";
            cbxPurposeName.ValueMember = "PurposeId";
            cbxPurposeName.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpStartDate.Value);
            var ED = Convert.ToDateTime(dtpEndDate.Value);
            var PN = Convert.ToInt32(cbxPurposeName.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetPurposeWiseDetail(SD,ED,PN);
            dgvPurposeAndDay.DataSource = list;
            FillDebit();
            FillCradit();
            txtTotal.Text = (float.Parse(label11.Text) - float.Parse(label13.Text)).ToString();
        }
    }
}
