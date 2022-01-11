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
    public partial class TotalAmountForm : Form
    {
        public TotalAmountForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillTotalGrid();
            FillAmountDebit();
            FillAmountCradit();

            //calculate total amount
            txtTotalAmount.Text = (float.Parse(label3.Text) - float.Parse(label5.Text)).ToString();
        }

        private void FillAmountCradit()
        {
            label5.Text = "0";
            for (int i = 0; i < dgvTotalAmount.Rows.Count; i++)
            {
                label5.Text =
                    Convert.ToString(double.Parse(label5.Text) +
                                     double.Parse(dgvTotalAmount.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void FillAmountDebit()
        {
            label3.Text = "0";
            for (int i = 0; i < dgvTotalAmount.Rows.Count; i++)
            {
                label3.Text =
                    Convert.ToString(double.Parse(label3.Text) +
                                     double.Parse(dgvTotalAmount.Rows[i].Cells[1].Value.ToString()));
            }
        }

        private void FillTotalGrid()
        {
            var context = new Manager();
            var list = context.GettTotal();
            dgvTotalAmount.DataSource = list;
        }
        
    }
}
