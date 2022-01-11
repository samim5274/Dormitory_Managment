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
    public partial class DipositFormcs : Form
    {
        public DipositFormcs()
        {
            InitializeComponent();
        }

        //private List<CartItem> ShopingCart = new List<CartItem>();
        private List< DipositMoneyDetail> TT = new List<DipositMoneyDetail>();
        

        private void DipositFormcs_Load(object sender, EventArgs e)
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
            lblTotal.Text = "0";
            for (int i = 0; i < dtpDipositView.Rows.Count; i++)
            {
                lblTotal.Text =
                    Convert.ToString(double.Parse(lblTotal.Text) +
                                     double.Parse(dtpDipositView.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void FillGridView()
        {
            var obj = new Manager();
            var list = obj.GetDipositGrid();
            dtpDipositView.DataSource = list;
        }

        private void ClearText()
        {
            cbxReciverName.Text = string.Empty;
            cbxPurpose.Text = string.Empty;
            cbxGiverName.Text = string.Empty;
            txtScarch.Text = string.Empty;
            txtMoney.Text = string.Empty;
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
                DIP.Money = Convert.ToDecimal(txtMoney.Text.Trim());
                DIP.Credit_Money = Convert.ToDecimal(txtCreaditMoney.Text.Trim());

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void dtpDipositView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       private void button1_Click(object sender, EventArgs e)
       {
           lblTotal.Text = "0";
           for (int i = 0; i < dtpDipositView.Rows.Count; i++)
           {
               lblTotal.Text =
                   Convert.ToString(double.Parse(lblTotal.Text) +
                                    double.Parse(dtpDipositView.Rows[i].Cells[4].Value.ToString()));
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
               SRC.Money = Convert.ToDecimal(txtMoney.Text.Trim());
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

       private void dtpDipositView_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           
       }

       private void dtpDipositView_DoubleClick(object sender, EventArgs e)
       {
             
       }

       private void dtpDipositView_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           //txtMoney.Text = dtpDipositView.SelectedRows[0].Cells[0].Value.ToString();
           //txtProduct.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           //cbxGiverName.Text = dtpDipositView.SelectedRows[0].Cells[1].Value.ToString();
           //cbxReciverName.Text = dtpDipositView.SelectedRows[0].Cells[2].Value.ToString();
           //txtMoney.Text = dtpDipositView.SelectedRows[0].Cells[4].Value.ToString();
       }

       private void btnScarch_Click_1(object sender, EventArgs e)
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
               MessageBox.Show(@"Not fount.Please try again.");
           }
       }
    }
}
