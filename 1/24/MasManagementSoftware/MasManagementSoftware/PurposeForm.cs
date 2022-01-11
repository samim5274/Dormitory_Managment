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
    public partial class PurposeForm : Form
    {
        public PurposeForm()
        {
            InitializeComponent();
        }

        private void btnSubmite_Click(object sender, EventArgs e)
        {
            try
            {
                var DOR = new DORMITORYEntities();
                var objPur = new PurposeInfo();

                objPur.PurposeName = txtPurposeName.Text.Trim();
                DOR.AddToPurposeInfoes(objPur);
                DOR.SaveChanges();
                MessageBox.Show(@"Purpose name Submited successfully.");
                ClearTextbox();
                FillPurpose();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erorr !");
            }
        }

        private void txtPurposeName_TextChanged(object sender, EventArgs e)
        {
            if (txtPurposeName.Text == "")
            {
                btnSubmite.Enabled = false;
            }
            else
            {
                btnSubmite.Enabled = true;
            }
        }

        private void PurposeForm_Load(object sender, EventArgs e)
        {
            btnSubmite.Enabled = false;
            ClearTextbox();
            FillPurpose();
        }

        private void FillPurpose()
        {
            var Manager = new Manager();
            var list = new Manager().GellPurposeName();
            cbxPurpose.DisplayMember = "PurposeName";
            cbxPurpose.ValueMember = "PurposeId";
            cbxPurpose.DataSource = list;
        }

        private void ClearTextbox()
        {
            txtPurposeName.Text = string.Empty;
            cbxPurpose.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

               
    }
}
