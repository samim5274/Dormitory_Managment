﻿namespace MasManagementSoftware
{
    partial class ShiftAndDepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDepAndShift = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepAndShift)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(553, 73);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(341, 37);
            this.cbxDepartment.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Department";
            // 
            // dgvDepAndShift
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.dgvDepAndShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepAndShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepAndShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepAndShift.Location = new System.Drawing.Point(38, 235);
            this.dgvDepAndShift.Name = "dgvDepAndShift";
            this.dgvDepAndShift.RowTemplate.Height = 24;
            this.dgvDepAndShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepAndShift.Size = new System.Drawing.Size(1195, 482);
            this.dgvDepAndShift.TabIndex = 30;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(289, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(740, 51);
            this.btnShow.TabIndex = 29;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbxShift
            // 
            this.cbxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(553, 123);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(341, 37);
            this.cbxShift.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Shift and Department wise Student Information";
            // 
            // ShiftAndDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1271, 733);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDepAndShift);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ShiftAndDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftAndDepartmentForm";
            this.Load += new System.EventHandler(this.ShiftAndDepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepAndShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDepAndShift;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbxShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}