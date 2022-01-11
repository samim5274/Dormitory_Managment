namespace MasManagementSoftware
{
    partial class TotalAmountLastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalDipo = new System.Windows.Forms.Label();
            this.lblTotalWithdraw = new System.Windows.Forms.Label();
            this.lblClosingDipo = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalClosingCash = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLastExpenses = new System.Windows.Forms.DataGridView();
            this.dgvLastTotal = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(361, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Closing Cash";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = global::MasManagementSoftware.Properties.Resources.bigstock_Closed_Padlock_On_Digital_Back_383628656;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShow.Location = new System.Drawing.Point(324, 146);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(659, 63);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(432, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Deposit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(410, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Withdraw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(407, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Closing Diposit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(403, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Expenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(355, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Closing Cash";
            // 
            // lblTotalDipo
            // 
            this.lblTotalDipo.AutoSize = true;
            this.lblTotalDipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalDipo.Location = new System.Drawing.Point(664, 222);
            this.lblTotalDipo.Name = "lblTotalDipo";
            this.lblTotalDipo.Size = new System.Drawing.Size(32, 32);
            this.lblTotalDipo.TabIndex = 7;
            this.lblTotalDipo.Text = "0";
            // 
            // lblTotalWithdraw
            // 
            this.lblTotalWithdraw.AutoSize = true;
            this.lblTotalWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalWithdraw.Location = new System.Drawing.Point(664, 268);
            this.lblTotalWithdraw.Name = "lblTotalWithdraw";
            this.lblTotalWithdraw.Size = new System.Drawing.Size(32, 32);
            this.lblTotalWithdraw.TabIndex = 8;
            this.lblTotalWithdraw.Text = "0";
            // 
            // lblClosingDipo
            // 
            this.lblClosingDipo.AutoSize = true;
            this.lblClosingDipo.BackColor = System.Drawing.Color.Transparent;
            this.lblClosingDipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingDipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClosingDipo.Location = new System.Drawing.Point(836, 368);
            this.lblClosingDipo.Name = "lblClosingDipo";
            this.lblClosingDipo.Size = new System.Drawing.Size(32, 32);
            this.lblClosingDipo.TabIndex = 9;
            this.lblClosingDipo.Text = "0";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalExpenses.Location = new System.Drawing.Point(836, 416);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(32, 32);
            this.lblTotalExpenses.TabIndex = 10;
            this.lblTotalExpenses.Text = "0";
            // 
            // lblTotalClosingCash
            // 
            this.lblTotalClosingCash.AutoSize = true;
            this.lblTotalClosingCash.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalClosingCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClosingCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalClosingCash.Location = new System.Drawing.Point(836, 513);
            this.lblTotalClosingCash.Name = "lblTotalClosingCash";
            this.lblTotalClosingCash.Size = new System.Drawing.Size(32, 32);
            this.lblTotalClosingCash.TabIndex = 11;
            this.lblTotalClosingCash.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(85, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1071, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "__________________________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1140, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 118);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dgvLastExpenses
            // 
            this.dgvLastExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastExpenses.Location = new System.Drawing.Point(1155, 21);
            this.dgvLastExpenses.Name = "dgvLastExpenses";
            this.dgvLastExpenses.RowTemplate.Height = 24;
            this.dgvLastExpenses.Size = new System.Drawing.Size(88, 86);
            this.dgvLastExpenses.TabIndex = 14;
            this.dgvLastExpenses.Visible = false;
            // 
            // dgvLastTotal
            // 
            this.dgvLastTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastTotal.Location = new System.Drawing.Point(27, 19);
            this.dgvLastTotal.Name = "dgvLastTotal";
            this.dgvLastTotal.RowTemplate.Height = 24;
            this.dgvLastTotal.Size = new System.Drawing.Size(72, 69);
            this.dgvLastTotal.TabIndex = 16;
            this.dgvLastTotal.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 101);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // dtpSDate
            // 
            this.dtpSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSDate.Location = new System.Drawing.Point(297, 102);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(279, 24);
            this.dtpSDate.TabIndex = 17;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDate.Location = new System.Drawing.Point(748, 102);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(279, 24);
            this.dtpEDate.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(182, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Start Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(626, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(85, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1071, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "__________________________________________________________________";
            // 
            // TotalAmountLastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MasManagementSoftware.Properties.Resources._36025017_natural_picture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 738);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.dgvLastTotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvLastExpenses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalClosingCash);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblClosingDipo);
            this.Controls.Add(this.lblTotalWithdraw);
            this.Controls.Add(this.lblTotalDipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TotalAmountLastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalAmountLastForm";
            this.Load += new System.EventHandler(this.TotalAmountLastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalDipo;
        private System.Windows.Forms.Label lblTotalWithdraw;
        private System.Windows.Forms.Label lblClosingDipo;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblTotalClosingCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLastExpenses;
        private System.Windows.Forms.DataGridView dgvLastTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
    }
}